﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ClinicConnect.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int? PatientId { get; set; }

    public int? DoctorId { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public bool? AppointmentStatus { get; set; }

    public string Reason { get; set; }

    public decimal? DoctorFee { get; set; }

    public virtual Doctor Doctor { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual Patient Patient { get; set; }
}