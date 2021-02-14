using Android.App;
using Android.OS;

namespace Laerdal.Xamarin.Dfu.Specific
{
    public class DfuNotificationActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Original Nordic-code below. We assume the app can take care of itself.
            // Not very useful hooking up notification click to app... If you need it: make your own DfuService+DfuNotification
            /*
            // If this activity is the root activity of the task, the app is not running
            if (IsTaskRoot)
            {
                // Start the app before finishing
                var intent = new Intent(this, typeof(MainActivity));
                intent.SetFlags(ActivityFlags.NewTask);
                intent.PutExtras(intent.Extras);
                StartActivity(intent);
            }
            */

            // Now finish, which will drop you to the activity at which you were at the top of the task stack
            Finish();
        }
    }
}