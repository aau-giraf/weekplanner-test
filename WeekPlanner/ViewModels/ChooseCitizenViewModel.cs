using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using IO.Swagger.Api;
using IO.Swagger.Model;
using WeekPlanner.ApplicationObjects;
using WeekPlanner.Services.Mocks;
using WeekPlanner.Services.Navigation;
using WeekPlanner.Services.Settings;
using WeekPlanner.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace WeekPlanner.ViewModels
{
    public class ChooseCitizenViewModel : ViewModelBase
    {
        private readonly IWeekApi _weekApi;
        private readonly IPictogramApi _pictogramApi;
        private ObservableCollection<GirafUserDTO> _citizens;
	    
	    public ObservableCollection<GirafUserDTO> Citizens {
		    get => _citizens;
		    set {
			    _citizens = value;
			    RaisePropertyChanged(() => Citizens);
		    }
	    }

        public ChooseCitizenViewModel(IWeekApi weekApi, IPictogramApi pictogramApi, INavigationService navigationService) : base(navigationService)
        {
            _weekApi = weekApi;
            _pictogramApi = pictogramApi;
        }

	    public ICommand ChooseCitizenCommand => new Command<GirafUserDTO>(async citizen => await ShowWeekSchedule(citizen));

        private async Task ShowWeekSchedule(GirafUserDTO citizen) {
            var schedule = GetSchedule(citizen);
            await NavigationService.NavigateToAsync<WeekPlannerViewModel>(citizen);
        }
        private GirafUserDTO GetSchedule(GirafUserDTO citizen) { return citizen; }

		public override async Task InitializeAsync(object navigationData)
		{
			if (navigationData is IEnumerable<GirafUserDTO> dtos)
			{
				Citizens = new ObservableCollection<GirafUserDTO>(dtos);
			}
			else
			{
				throw new ArgumentException("Must be of type IEnumerable<GirafUserDTO>", nameof(navigationData));
			}
		}
	}
}
