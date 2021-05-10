using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Laerdal.Dfu.Sample.Helpers
{
    public static class EnumerableExtensions
    {
        public static void Enqueue<T>(this ConcurrentQueue<T> queue, T obj, int max)
        {
            queue.Enqueue(obj);
            while (queue.Count > max)
            {
                queue.TryDequeue(out var _);
            }
        }
        
        public static T GetOrDefault<T>(this IEnumerable<T> enumerable, int index, T defaultValue = default)
        {
            if (enumerable is null)
            {
                return defaultValue;
            }

            var array = enumerable.ToArray();
            if (array.Length <= index)
            {
                return defaultValue;
            }

            try
            {
                return array[index];
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
        
        
        public static void UpdateFrom<TInput, TOutput>(this IEnumerable<TOutput> output,
                                                       IEnumerable<TInput> input,
                                                       Func<TInput, TOutput, bool> areRepresentingTheSameItem,
                                                       Action<TInput> addAction,
                                                       Action<TOutput> removeAction)
        {
            if (output == null)
            {
                throw new ArgumentNullException();
            }
            
            if (input == null)
            {
                input = new List<TInput>();
            }

            if (areRepresentingTheSameItem == null)
            {
                throw new ArgumentNullException();
            }

            if (addAction == null)
            {
                throw new ArgumentNullException();
            }

            if (removeAction == null)
            {
                throw new ArgumentNullException();
            }

            var outputList = output.ToList();
            var inputList = input.ToList();

            var toBeAdded = inputList.Where(inputItem => outputList.All(outputItem => !areRepresentingTheSameItem(inputItem, outputItem))).ToList();
            var toBeRemoved = outputList.Where(outputItem => inputList.All(inputItem => !areRepresentingTheSameItem(inputItem, outputItem))).ToList();

            lock (output)
            {
                foreach (var itemToBeAdded in toBeAdded)
                {
                    addAction(itemToBeAdded);
                }

                foreach (var itemToBeRemoved in toBeRemoved)
                {
                    removeAction(itemToBeRemoved);
                }
            }
        }

        public static void UpdateFrom<TInput, TOutput>(this IList<TOutput> output, IList<TInput> input, Func<TInput, TOutput, bool> areRepresentingTheSameItem, Func<TInput, TOutput> fromInputTypeToOutputTypeConversion)
        {
            if (fromInputTypeToOutputTypeConversion == null)
            {
                throw new ArgumentNullException();
            }

            lock (output)
            {
                output.UpdateFrom(input, areRepresentingTheSameItem, i => output.Add(fromInputTypeToOutputTypeConversion.Invoke(i)), o => output.Remove(o));
            }
        }

        public static void UpdateFrom<TInput, TOutput>(this IList<TOutput> output, IList<TInput> input, Func<TInput, TOutput> fromInputTypeToOutputTypeConversion) where TOutput : IEquatable<TInput>
        {
            lock (output)
            {
                output.UpdateFrom(input, (i, o) => i.Equals(o), i => output.Add(fromInputTypeToOutputTypeConversion.Invoke(i)), o => output.Remove(o));
            }
        }

        public static void UpdateFrom<T>(this IList<T> output, IList<T> input, Func<T, T, bool> areRepresentingTheSameItem)
        {
            output.UpdateFrom(input, areRepresentingTheSameItem, i => i);
        }

        public static void UpdateFrom<T>(this IList<T> output, IList<T> input)
        {
            output.UpdateFrom(input, (equatable1, equatable2) => equatable1.Equals(equatable2), i => i);
        }
    }
}