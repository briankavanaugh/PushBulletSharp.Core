﻿using System.Runtime.Serialization;

namespace PushBulletSharp.Core.Models.Requests
{
    [DataContract]
    public class ChannelSubscriptionRequest
    {
        /// <summary>
        /// Gets or sets the channel_tag.
        /// </summary>
        /// <value>
        /// The channel_tag.
        /// </value>
        [DataMember(Name = "channel_tag")]
        public string ChannelTag { get; set; }
    }
}