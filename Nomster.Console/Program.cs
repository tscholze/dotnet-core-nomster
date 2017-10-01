using System;
using Nomster.Core.ViewModel;

namespace Nomster.Console
{
    class Program
    {
        #region Private member

        MainViewModel viewModel;

        #endregion

        static void Main(string[] args)
        {
            Program p = new Program();
            p.viewModel = new MainViewModel();

            p.WriteLogo();
            p.WriteLunches();
            p.WriteExitPrompt();
        }

        #region Print helper 

        void WriteLogo()
        {
            LogoHelper.WriteLogo();
            WriteHelper.WriteSpacer();
            WriteHelper.WriteSpacer();
        }

        void WriteLunches()
        {
            // Write headline
            WriteHelper.Write($"There are {viewModel.Lunches.Count} lunch suggestions for today:", ConsoleColor.Green);
            WriteHelper.WriteSpacer();

            // Write list
            foreach (var lunch in viewModel.Lunches)
            {
                var time = lunch.OfficeLeftDate.ToString("HH:mm");
                WriteHelper.Write($"  -> {lunch.Title} will leave the office at {time} with {lunch.NumberOfAttendees} attendee(s)");
            }

            // Write footer
            WriteHelper.WriteSpacer();
            WriteHelper.Write("Wanna join? Use any device that is near to you, to board a lunch!", ConsoleColor.Green);
        }

        void WriteExitPrompt()
        {
            WriteHelper.WriteSpacer();
            WriteHelper.WriteSpacer();
            WriteHelper.WriteSpacer();
            WriteHelper.WriteSpacer();
            System.Console.WriteLine("Press ENTER to exit");
            System.Console.ReadLine();
        }

        #endregion
    }
}
