﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyCart.Models.Ecommerce
{
    /// <summary>
    /// Model for review list.
    /// </summary>
    [DataContract]
    public class Review
    {
        #region Field

        private List<string> images;

        private string profileImage;

        private DateTime reviewedDate;

        #endregion

        /// <summary>
        /// Gets or sets the property that has been bound with an image, which displays the customer image.
        /// </summary>
        [DataMember(Name = "profileimage")]
        public string ProfileImage
        {
            get { return profileImage; }
            set { profileImage = value; }
        }

        /// <summary>
        /// Gets or sets the property that has been bound with an image, which displays the customer added image.
        /// </summary>
        [DataMember(Name = "images")]
        public List<string> Images
        {
            get
            {
                return images;
            }
            set { images = value; }
        }

        /// <summary>
        /// Gets or sets the property that has been bound with a label, which displays the customer name.
        /// </summary>
        [DataMember(Name = "customername")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the property that has been bound with a label, which displays the commented date.
        /// </summary>
        public DateTime ReviewedDate
        {
            get
            {
                return DateTime.MinValue != Convert.ToDateTime(StringDate)
                    ? Convert.ToDateTime(StringDate)
                    : reviewedDate;
            }
            set { reviewedDate = value; }
        }

        /// <summary>
        /// Gets or sets the property that has been bound with a label, which displays the commented date.
        /// </summary>
        [DataMember(Name = "revieweddate")]
        public string StringDate { get; set; }

        /// <summary>
        /// Gets or sets the property that has been bound with SfRating control, which displays the rating of the item.
        /// </summary>
        [DataMember(Name = "rating")]
        public double Rating { get; set; }

        /// <summary>
        /// Gets or sets the property that has been bound with a label, which displays the comment updated by the customer.
        /// </summary>
        [DataMember(Name = "comment")]
        public string Comment { get; set; }
    }
}
