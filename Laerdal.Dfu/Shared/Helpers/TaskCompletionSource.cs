using System.Threading.Tasks;

namespace Laerdal.Dfu.Helpers
{
    public class TaskCompletionSource : TaskCompletionSource<object>
    {
        public void SetCompleted()
        {
            SetResult(null);
        }

        public void TrySetCompleted()
        {
            TrySetResult(null);
        }
    }
}