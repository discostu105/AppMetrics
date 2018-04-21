﻿// <copyright file="MeterOptions.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

namespace App.Metrics.Meter
{
    /// <summary>
    ///     Configuration of an <see cref="IMeterMetric" /> that will be measured
    /// </summary>
    /// <seealso cref="MetricValueOptionsBase" />
    public class MeterOptions : MetricValueOptionsBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MeterOptions" /> class.
        /// </summary>
        public MeterOptions()
        {
            RateUnit = TimeUnit.Minutes;
        }

        /// <summary>
        ///     Gets or sets the rate unit used for visualization which defaults to Minutes
        /// </summary>
        /// <value>
        ///     The rate unit.
        /// </value>
        public TimeUnit RateUnit { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether or not to report the counter's set items. Defaults to <c>true</c>.
        /// </summary>
        /// <value>
        ///     <c>true</c> if [report set items]; otherwise, <c>false</c>.
        /// </value>
        public bool ReportSetItems { get; set; }
    }
}