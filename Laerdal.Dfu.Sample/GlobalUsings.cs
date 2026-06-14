global using System;
global using System.Collections.Concurrent;
global using System.Collections.Generic;
global using System.Collections.ObjectModel;
global using System.ComponentModel;
global using System.Linq;
global using System.Reflection;
global using System.Runtime.CompilerServices;
global using System.Threading;
global using System.Threading.Tasks;

global using Bluetooth.Abstractions.Scanning;
global using Bluetooth.Abstractions.Scanning.Options;
global using DeviceListChangedEventArgs = Bluetooth.Abstractions.Scanning.EventArgs.DeviceListChangedEventArgs;

global using CommunityToolkit.Maui;
global using CommunityToolkit.Mvvm.Input;

global using Laerdal.Dfu;
global using Laerdal.Dfu.Enums;

global using Laerdal.Dfu.Sample.Infrastructure;
global using Laerdal.Dfu.Sample.Pages;
global using Laerdal.Dfu.Sample.Services;
global using Laerdal.Dfu.Sample.ViewModels;

global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Maui.ApplicationModel;
global using Microsoft.Maui.Controls;
global using Microsoft.Maui.Storage;

#if IOS || MACCATALYST
global using Foundation;
global using UIKit;
#elif ANDROID
global using Android.App;
global using Android.Content;
global using Android.OS;
#endif
