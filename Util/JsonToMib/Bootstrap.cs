﻿using PCL.ViewModel;
using PCL.ViewModel.Logging;
using PCL.ViewModel.IoC;

namespace JsonToMib

           // container.RegisterInstance(new Log4NetLogger("General"));
           // container.RegisterInstance(new Logging.RollingLogger());
           // container.RegisterInstance<ILogger>(Logger.Current);


            container.RegisterInstance<IApplicationSettings>(new ApplicationSettings());

            return;