﻿// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="DurationItemField.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Linq;

namespace PodioPCL.Models.ItemFields
{
	/// <summary>
	/// Class DurationItemField.
	/// </summary>
    public class DurationItemField : ItemField
    {
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
        public TimeSpan? Value
        {
            get
            {
                if (this.HasValue("value"))
                {
                    return TimeSpan.FromSeconds(Convert.ToDouble((Int64)this.Values.First()["value"]));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                ensureValuesInitialized(true);
                if (value != null)
                {
                    this.Values.First()["value"] = (Int64)value.Value.TotalSeconds;
                }
                else {
                    this.Values.First()["value"] = null;
                }
            }
        }

    }

}
