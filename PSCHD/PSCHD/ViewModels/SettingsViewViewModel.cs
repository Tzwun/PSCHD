using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PSCHD.Core.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Unity;

namespace PSCHD.ViewModels
{
    public class SettingsViewViewModel : ViewModelBase
    {

        public SettingsViewViewModel(IUnityContainer unityContainer)
            : base(unityContainer)
        {
            Swatches = new SwatchesProvider().Swatches;
        }

        public IEnumerable<Swatch> Swatches { get; }

        public ICommand ApplyPrimaryCommand { get; } = new DelegateCommand<Swatch>(o => ApplyPrimary((Swatch)o!));

        private static void ApplyPrimary(Swatch swatch)
            => ModifyTheme(theme => theme.SetPrimaryColor(swatch.ExemplarHue.Color));

        public ICommand ApplyAccentCommand { get; } = new DelegateCommand<Swatch>(o => ApplyAccent((Swatch)o!));

        private static void ApplyAccent(Swatch swatch)
        {
            if (swatch is { AccentExemplarHue: not null })
            {
                ModifyTheme(theme => theme.SetSecondaryColor(swatch.AccentExemplarHue.Color));
            }
        }

        private static void ModifyTheme(Action<ITheme> modificationAction)
        {
            var paletteHelper = new PaletteHelper();
            ITheme theme = paletteHelper.GetTheme();

            modificationAction?.Invoke(theme);

            paletteHelper.SetTheme(theme);
        }
    }
}
