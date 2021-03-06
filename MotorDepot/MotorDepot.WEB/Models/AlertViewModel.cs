﻿using MotorDepot.WEB.Models.Enums;

namespace MotorDepot.WEB.Models
{
    public class AlertViewModel
    {
        public string Text { get; set; }
        public AlertType Type { get; set; }

        public AlertViewModel(string text, AlertType type)
        {
            Text = text;
            Type = type;
        }
    }
}