using System;
using CustomDialogs;

namespace CloudBackup.Gui {
    public static class DialogUtilities {
        public static InputResult<string> ShowLinkInput(string displayname, string link) {
            return CustomDialog.ShowTextInput($"{displayname}'s link", $"Edit {displayname}'s link", link, Properties.Resources._64pxLink);
        }
        public static InputResult<string> ShowPasswordInput(string displayName, string password) {
            var profile = PasswordGeneratorDialogProfile.NewPassword;
            profile.Title = $"Password | {displayName}";
            profile.Message = $"{displayName}'s password";
            profile.Password = password;

            return CustomDialog.ShowPasswordGenerator(profile);
        }

        public static void ShowError(ProgressReport report) { 
            if(report.Exception == null) CustomDialog.ShowError(report.Exception);
            else CustomDialog.ShowError("Error", "There was an error.");
        }
    }
}
