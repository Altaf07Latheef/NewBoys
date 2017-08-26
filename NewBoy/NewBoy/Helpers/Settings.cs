// Helpers/Settings.cs
using Plugin.SecureStorage;
using Plugin.SecureStorage.Abstractions;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace NewBoy.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

        private static ISecureStorage SecureSettings
        {
            get
            {
                return CrossSecureStorage.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "Settings_key";
		private static readonly string SettingsDefault = string.Empty;

		#endregion


		public static string Settings_key
		{
			get
			{
				return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(SettingsKey, value);
			}
		}

	}
}