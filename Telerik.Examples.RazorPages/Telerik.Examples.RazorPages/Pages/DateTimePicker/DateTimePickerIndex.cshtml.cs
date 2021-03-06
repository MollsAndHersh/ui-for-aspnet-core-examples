﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Telerik.Examples.RazorPages.Pages.DateTimePicker
{
    public class DateTimePickerIndexModel : PageModel
    {
        public DateTime? SelectedDate { get; set; }
        public void OnGet()
        {
            SelectedDate = new DateTime(2021, 5, 5);
        }

        public void OnPost(DateTime? selectedDate)
        {
            SelectedDate = selectedDate;
        }
    }
}