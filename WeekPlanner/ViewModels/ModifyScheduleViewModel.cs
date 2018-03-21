﻿using System;
using System.IO;
using System.Net;
using System.Text;
using IO.Swagger.Model;
using IO.Swagger.Client;
using IO.Swagger.Api;
using System.Threading.Tasks;
using WeekPlanner.ViewModels.Base;
using WeekPlanner.Helpers;
using Xamarin.Forms;
using WeekPlanner.Services.Navigation;
using System.Windows.Input;

namespace WeekPlanner.ViewModels
{
    public class ModifyScheduleViewModel : ViewModelBase
    {
        private readonly IWeekApi _weekApi;

        public ModifyScheduleViewModel(INavigationService navigationService, IWeekApi weekApi) : base(navigationService)
        {
            _weekApi = weekApi;
            MessagingCenter.Subscribe<ModifyScheduleViewModel, string>(this, MessageKeys.ScheduleSaveRequest, async (sender, args) => await SaveSchedule());
        }

        public WeekDTO Schedule;

        public ICommand SaveCommand => new Command(async () => await SaveSchedule());

        public async override Task InitializeAsync(object navigationData)
        {
            if (navigationData is WeekDTO week)
            {
                // Modifying an existing schedule
                Schedule = week;
            }
            else
            {
                // Creating a new schedule
                Schedule = new WeekDTO();
            }
        }

        // Saves a the schedule 
        public async Task SaveSchedule()
        {
            if (Schedule.Id is null)
            {
                await SaveNewSchedule();
            }
            else
            {
                await UpdateExistingSchedule();
            }
        }

        private async Task SaveNewSchedule()
        {
            ResponseWeekDTO result;

            try
            {
                // Saves new schedule
                result = await _weekApi.V1WeekPostAsync(Schedule);
            }
            catch (ApiException)
            {
                // TODO make a "ServerDownError"
                var friendlyErrorMessage = ErrorCodeHelper.ToFriendlyString(ResponseWeekDTO.ErrorKeyEnum.Error);
                MessagingCenter.Send(this, MessageKeys.ScheduleSaveFailed, friendlyErrorMessage);
                return;
            }
        }

        private async Task UpdateExistingSchedule()
        {
            ResponseWeekDTO result;

            try
            {
                // Updates an existing schedule
                result = await _weekApi.V1WeekByIdPutAsync((int)Schedule.Id, Schedule); // TODO remove cast to int when backend has been fixed
            }
            catch (ApiException)
            {
                // TODO make a "ServerDownError"
                var friendlyErrorMessage = ErrorCodeHelper.ToFriendlyString(ResponseWeekDTO.ErrorKeyEnum.Error);
                MessagingCenter.Send(this, MessageKeys.ScheduleUpdateFailed, friendlyErrorMessage);
                return;
            }
        }

	}
}
