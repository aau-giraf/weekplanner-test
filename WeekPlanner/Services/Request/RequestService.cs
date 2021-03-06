﻿using System;
using System.Threading.Tasks;
using IO.Swagger.Client;
using IO.Swagger.Model;
using WeekPlanner.Helpers;
using WeekPlanner.ViewModels.Base;
using Xamarin.Forms;

namespace WeekPlanner.Services.Request
{
	public class RequestService : IRequestService
	{
		private readonly IDialogService _dialogService;

		public RequestService(IDialogService dialogService)
		{
			_dialogService = dialogService;
		}

        public async Task SendRequestAndThenAsync<TR>(
            Func<Task<TR>> requestAsync, 
            Func<TR, Task> onSuccessAsync = null,
            Func<Task> onExceptionAsync = null,
            Func<Task> onRequestFailedAsync = null,
            string exceptionErrorMessageKey = MessageKeys.RequestFailed,
            string requestFailedMessageKey = MessageKeys.RequestFailed)
        {
            // TODO: Check for internet connection first.
            dynamic result;
            try
            {
                result = await requestAsync.Invoke();
            }
            catch (ApiException e)
            {
                if (onExceptionAsync != null)
                {
                    await onExceptionAsync.Invoke();
                } else {
                    var friendlyErrorMessage = ErrorCodeHelper.ToFriendlyString(ResponseString.ErrorKeyEnum.Error);
                    await _dialogService.ShowAlertAsync(message: friendlyErrorMessage, title: "Fejl");
                }
                return;
            }

			if (result.Success == true)
			{
				await onSuccessAsync?.Invoke(result);
			}
			else
			{
				if (onRequestFailedAsync != null)
				{
					await onRequestFailedAsync.Invoke();
				}
				else
				{
                    var friendlyErrorMessage = ErrorCodeHelper.ToFriendlyString(result.ErrorKey);
                    await _dialogService.ShowAlertAsync(message: friendlyErrorMessage, title: "Fejl");
				}
			}
		}

        public async Task SendRequest<TR>(Task<TR> requestAsync) {
            await SendRequestAndThenAsync(() => requestAsync);
        }

        public async Task SendRequestAndThenAsync<TR>(Func<Task<TR>> requestAsync,
            Action<TR> onSuccess,
            Func<Task> onExceptionAsync = null,
            Func<Task> onRequestFailedAsync = null,
            string exceptionErrorMessageKey = MessageKeys.RequestFailed,
            string requestFailedMessageKey = MessageKeys.RequestFailed)
        {
            async Task OnSuccessAsync(TR result)
            {
                onSuccess.Invoke(result);
            }
               
            await SendRequestAndThenAsync(requestAsync, OnSuccessAsync,
                onExceptionAsync, onRequestFailedAsync, exceptionErrorMessageKey, requestFailedMessageKey);
        }
    }
}