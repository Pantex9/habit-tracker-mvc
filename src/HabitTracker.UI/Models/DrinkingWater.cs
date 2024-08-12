﻿using System.ComponentModel.DataAnnotations;

namespace HabitTracker.WebUI.Models;

public class DrinkingWater
{
    public int Id { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime Date { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Value for {0} must be positive.")]
    public int Quantity { get; set; }
}
