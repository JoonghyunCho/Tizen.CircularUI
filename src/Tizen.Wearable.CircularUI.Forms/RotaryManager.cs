﻿/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using Xamarin.Forms;

namespace Tizen.Wearable.CircularUI.Forms
{
    /// <summary>
    /// The RotaryManager provides an event for the global rotary event for wearable devices.
    /// </summary>
    /// <since_tizen> 4 </since_tizen>
    /// <example>
    /// <code>
    /// RotaryManager.Rotated += (s, e) =>
    /// {
    ///      Console.WriteLine($"Rotated! Rotated direction: ${e.IsClockwise}");
    /// };
    /// </code>
    /// </example>
    public static class RotaryManager
    {
        static IRotaryService ProxyService { get; } = DependencyService.Get<IRotaryService>();

        /// <summary>
        /// Rotated will be triggered when the rotatable device like the Galaxy Watch Bezel is rotated.
        /// </summary>
        public static event EventHandler<RotaryEventArgs> Rotated
        {
            add
            {
                ProxyService.Rotated += value;
            }
            remove
            {
                ProxyService.Rotated -= value;
            }
        }
    }
}