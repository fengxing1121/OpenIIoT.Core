﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █    ▄█     █▄                                                      ▄███████▄
      █   ███     ███                                                    ███    ███
      █   ███     ███  █  ██▄▄▄▄  ██████▄   ██████   █     █    ▄█████   ███    ███  █         ▄█████      ██       ▄█████  ██████     █████    ▄▄██▄▄▄
      █   ███     ███ ██  ██▀▀▀█▄ ██   ▀██ ██    ██ ██     ██   ██  ▀    ███    ███ ██         ██   ██ ▀███████▄   ██   ▀█ ██    ██   ██  ██  ▄█▀▀██▀▀█▄
      █   ███     ███ ██▌ ██   ██ ██    ██ ██    ██ ██     ██   ██     ▀█████████▀  ██         ██   ██     ██  ▀  ▄██▄▄    ██    ██  ▄██▄▄█▀  ██  ██  ██
      █   ███     ███ ██  ██   ██ ██    ██ ██    ██ ██     ██ ▀███████   ███        ██       ▀████████     ██    ▀▀██▀▀    ██    ██ ▀███████  ██  ██  ██
      █   ███ ▄█▄ ███ ██  ██   ██ ██   ▄██ ██    ██ ██ ▄█▄ ██    ▄  ██   ███        ██▌    ▄   ██   ██     ██      ██      ██    ██   ██  ██  ██  ██  ██
      █    ▀███▀███▀  █    █   █  ██████▀   ██████   ███▀███   ▄████▀   ▄████▀      ████▄▄██   ██   █▀    ▄██▀     ██       ██████    ██  ██   █  ██  █
      █
      █    ▄█                                     ▄███████▄
      █   ███                                    ███    ███
      █   ███▌     ██       ▄█████    ▄▄██▄▄▄    ███    ███    █████  ██████   █    █   █  ██████▄     ▄█████    █████
      █   ███▌ ▀███████▄   ██   █   ▄█▀▀██▀▀█▄   ███    ███   ██  ██ ██    ██ ██    ██ ██  ██   ▀██   ██   █    ██  ██
      █   ███▌     ██  ▀  ▄██▄▄     ██  ██  ██ ▀█████████▀   ▄██▄▄█▀ ██    ██ ██    ██ ██▌ ██    ██  ▄██▄▄     ▄██▄▄█▀
      █   ███      ██    ▀▀██▀▀     ██  ██  ██   ███        ▀███████ ██    ██ ██    ██ ██  ██    ██ ▀▀██▀▀    ▀███████
      █   ███      ██      ██   █   ██  ██  ██   ███          ██  ██ ██    ██  █▄  ▄█  ██  ██   ▄██   ██   █    ██  ██
      █   █▀      ▄██▀     ███████   █  ██  █   ▄████▀        ██  ██  ██████    ▀██▀   █   ██████▀    ███████   ██  ██
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Provides Platform statistics and metrics for the Windows Platform on which the application is run.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The GNU Affero General Public License (GNU AGPL)
      █
      █  Copyright (C) 2016 JP Dillingham (jp@dillingham.ws)
      █
      █  This program is free software: you can redistribute it and/or modify
      █  it under the terms of the GNU Affero General Public License as published by
      █  the Free Software Foundation, either version 3 of the License, or
      █  (at your option) any later version.
      █
      █  This program is distributed in the hope that it will be useful,
      █  but WITHOUT ANY WARRANTY; without even the implied warranty of
      █  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      █  GNU Affero General Public License for more details.
      █
      █  You should have received a copy of the GNU Affero General Public License
      █  along with this program.  If not, see <http://www.gnu.org/licenses/>.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                            */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using OpenIIoT.SDK.Common;
using OpenIIoT.SDK.Common.Provider.ItemProvider;

namespace OpenIIoT.Core.Platform.Windows
{
    /// <summary>
    ///     Provides Platform statistics and metrics for the Windows Platform on which the application is run.
    /// </summary>
    public class WindowsPlatformItemProvider : ItemProvider, IDisposable
    {
        #region Private Fields

        /// <summary>
        ///     The dictionary of <see cref="Func{T}"/> delegates for each Item.
        /// </summary>
        private Dictionary<string, Func<object>> actions;

        /// <summary>
        ///     PerformanceCounter for the CPU % Idle Time counter.
        /// </summary>
        private PerformanceCounter cpuIdle;

        /// <summary>
        ///     PerformanceCounter for the CPU % Processor Time counter.
        /// </summary>
        private PerformanceCounter cpuUsed;

        /// <summary>
        ///     The last retrieved value for the CPU % Idle Time PerformanceCounter.
        /// </summary>
        private double lastCPUIdle;

        /// <summary>
        ///     The last retrieved value for the CPU % Processor Time PerformanceCounter.
        /// </summary>
        private double lastCPUUsed;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="WindowsPlatformItemProvider"/> class.
        /// </summary>
        /// <param name="itemProviderName">The name of the Item Provider.</param>
        public WindowsPlatformItemProvider(string itemProviderName) : base(itemProviderName)
        {
            actions = new Dictionary<string, Func<object>>();

            cpuUsed = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuIdle = new PerformanceCounter("Processor", "% Idle Time", "_Total");

            InitializeItems();
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        ///     Disposes this <see cref="WindowsPlatformItemProvider"/> .
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     Reads and returns the current value of the specified <see cref="Item"/>.
        /// </summary>
        /// <param name="item">The Item to read.</param>
        /// <returns>The value of the specified Item.</returns>
        public override object Read(Item item)
        {
            object retVal = default(object);

            if (actions.ContainsKey(item.FQN))
            {
                return actions[item.FQN]();
            }

            return retVal;
        }

        /// <summary>
        ///     Asynchronously reads and returns the current value of the specified <see cref="Item"/>
        /// </summary>
        /// <param name="item">The Item to read.</param>
        /// <returns>The value of the specified Item.</returns>
        public override async Task<object> ReadAsync(Item item)
        {
            return await Task.Run(() => Read(item));
        }

        #endregion Public Methods

        #region Protected Methods

        /// <summary>
        ///     Disposes the <see cref="cpuIdle"/> and <see cref="cpuUsed"/> fields.
        /// </summary>
        /// <param name="disposing">Indicates whether the object is in the process of disposing.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                cpuIdle.Dispose();
                cpuUsed.Dispose();
            }
        }

        #endregion Protected Methods

        #region Private Methods

        /// <summary>
        ///     Initializes the <see cref="Item"/> tree.
        /// </summary>
        private void InitializeItems()
        {
            // instantiate an item root
            ItemRoot = new Item(ItemProviderName, this);

            // create CPU items
            Item cpuRoot = ItemRoot.AddChild(new Item("CPU", this)).ReturnValue;

            // % CPU used
            Item cpuProcessorTime = new Item("CPU.% Processor Time", this);
            cpuRoot.AddChild(cpuProcessorTime);

            actions.Add(
                cpuProcessorTime.FQN,
                () =>
                {
                    lastCPUUsed = cpuUsed.NextValue();
                    return lastCPUUsed;
                });

            // % CPU Idle
            Item cpuIdleTime = new Item("CPU.% Idle Time", this);
            cpuRoot.AddChild(cpuIdleTime);

            actions.Add(
                cpuIdleTime.FQN,
                () =>
                {
                    lastCPUIdle = cpuIdle.NextValue();
                    return lastCPUIdle;
                });

            // prepare variables to use for processor time. you need two successive values to report accurately so rather than
            // sleeping the thread we will just keep track from call to call. the first values will always be zero and that's ok.
            lastCPUUsed = 0;
            lastCPUIdle = 0;

            // create memory items
            Item memRoot = ItemRoot.AddChild(new Item("Memory", this)).ReturnValue;

            // total memory
            Item memoryTotal = new Item("Memory.Total", this);
            memRoot.AddChild(memoryTotal);

            actions.Add(
                memoryTotal.FQN,
                () =>
                {
                    return 0;
                });

            // available memory
            Item memoryAvailable = new Item("Memory.Available", this);
            memRoot.AddChild(memoryAvailable);

            actions.Add(
                memoryAvailable.FQN,
                () =>
                {
                    return new PerformanceCounter("Memory", "Available Bytes").NextValue();
                });

            // cached memory
            Item memoryCached = new Item("Memory.Cached", this);
            memRoot.AddChild(memoryCached);

            actions.Add(
                memoryCached.FQN,
                () =>
                {
                    return new PerformanceCounter("Memory", "Cache Bytes").NextValue();
                });

            // used memory
            Item memoryUsed = new Item("Memory.% Used", this);
            memRoot.AddChild(memoryUsed);

            actions.Add(
                memoryUsed.FQN,
                () =>
                {
                    return new PerformanceCounter("Memory", "% Committed Bytes In Use").NextValue();
                });

            // create drive items
            Item driveRoot = ItemRoot.AddChild(new Item("Drives", this)).ReturnValue;

            // system drive
            Item sysDriveRoot = driveRoot.AddChild(new Item("Drives.System", this)).ReturnValue;
            sysDriveRoot.AddChild(new Item("Drives.System.Name", this));
            sysDriveRoot.AddChild(new Item("Path", this));
            sysDriveRoot.AddChild(new Item("Type", this));
            sysDriveRoot.AddChild(new Item("Capacity", this));
            sysDriveRoot.AddChild(new Item("UsedSpace", this));
            sysDriveRoot.AddChild(new Item("FreeSpace", this));
            sysDriveRoot.AddChild(new Item("PercentUsed", this));
            sysDriveRoot.AddChild(new Item("PercentFree", this));

            // data drive
            Item dataDriveRoot = driveRoot.AddChild(new Item("Data", this)).ReturnValue;
            dataDriveRoot.AddChild(new Item("Name", this));
            dataDriveRoot.AddChild(new Item("Path", this));
            dataDriveRoot.AddChild(new Item("Type", this));
            dataDriveRoot.AddChild(new Item("Capacity", this));
            dataDriveRoot.AddChild(new Item("UsedSpace", this));
            dataDriveRoot.AddChild(new Item("FreeSpace", this));
            dataDriveRoot.AddChild(new Item("PercentUsed", this));
            dataDriveRoot.AddChild(new Item("PercentFree", this));
        }

        #endregion Private Methods
    }
}