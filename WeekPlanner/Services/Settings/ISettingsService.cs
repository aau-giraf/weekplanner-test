﻿namespace WeekPlanner.Services.Settings
{
    public interface ISettingsService
    {
        bool UseMocks { get; set; }
        
        string DepartmentAuthToken { get; set; }
        string CitizenAuthToken { get; set; }

        void UseTokenFor(UserType userType);

        int CurrentDepartment { get; set; }
    }

    public enum UserType
    {
        Citizen,
        Department
    }
}