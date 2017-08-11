﻿/*
 * Copyright(c) 2017 Microsoft Corporation. All rights reserved. 
 * 
 * This code is licensed under the MIT License (MIT). 
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal 
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
 * of the Software, and to permit persons to whom the Software is furnished to do 
 * so, subject to the following conditions: 
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software. 
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE. 
*/

using System.Globalization;
using System.Runtime.Serialization;

namespace BingMapsRESTToolkit
{
    [DataContract]
    public class BoundingBox
    {
        #region Constructor

        public BoundingBox()
        {

        }

        /// <summary>
        /// Bounding box generated from edge coordinates.  
        /// </summary>
        /// <param name="edges">The edges of the bounding box. Structure [South Latitude, West Longitude, North Latitude, East Longitude]</param>
        public BoundingBox(double[] edges)
        {
            if (edges != null && edges.Length >= 4)
            {
                SouthLatitude = edges[0];
                WestLongitude = edges[1];
                NorthLatitude = edges[2];
                EastLongitude = edges[3];
            }
        }

        #endregion

        #region Public Properties

        [DataMember(Name = "southLatitude", EmitDefaultValue = false)]
        public double SouthLatitude { get; set; }

        [DataMember(Name = "westLongitude", EmitDefaultValue = false)]
        public double WestLongitude { get; set; }

        [DataMember(Name = "northLatitude", EmitDefaultValue = false)]
        public double NorthLatitude { get; set; }

        [DataMember(Name = "eastLongitude", EmitDefaultValue = false)]
        public double EastLongitude { get; set; }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0:0.#####},{1:0.#####},{2:0.#####},{3:0.#####}",
                    SouthLatitude,
                    WestLongitude,
                    NorthLatitude,
                    EastLongitude);
        }

        #endregion
    }
}
