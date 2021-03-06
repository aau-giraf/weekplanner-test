﻿using System.Threading.Tasks;
using IO.Swagger.Model;


namespace WeekPlanner.Services.Settings
{
    public interface ISettingsService
    {
        string BaseEndpoint { get; set; }
        string AuthToken { get; set; }
        bool IsInGuardianMode { get; set; }
        SettingDTO CurrentCitizenSettingDTO { get; set; }
        UserNameDTO CurrentCitizen { get; set; }
        void SetTheme(bool toDefault = false);
        long DepartmentId { get; set; }
		bool MasterPageShowable { get; }
        void ClearSettings();
    }


    public enum UserType
    {
        Citizen,
        Guardian
    }
}