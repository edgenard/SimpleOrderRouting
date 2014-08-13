﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IOrderExecutedSubscriber.cs" company="">
// //   Copyright 2014 Thomas PIERRAIN, Tomasz JASKULA
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace SimpleOrderRouting.Tests
{
    using SimpleOrderRouting.Journey1;

    /// <summary>
    /// Helper interface for mocking subscribers to the OrderExecuted event (NSubstitute thing).
    /// </summary>
    public interface IOrderExecutedSubscriber
    {
        /// <summary>
        /// Delegate for OrderExecuted callback.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="OrderExecutedEventArgs"/> instance containing the event data.</param>
        void OrderExecuted(object sender, OrderExecutedEventArgs e);
    }
}