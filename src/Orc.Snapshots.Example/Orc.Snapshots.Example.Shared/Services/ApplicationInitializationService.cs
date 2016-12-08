﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationInitializationService.cs" company="WildGums">
//   Copyright (c) 2008 - 2015 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Orc.Snapshots.Example.Services
{
    using System;
    using Orchestra.Services;
    using System.Threading.Tasks;
    using System.Windows.Media;
    using Catel;
    using Catel.IoC;
    using Catel.Threading;
    using Orchestra.Markup;
    using Snapshots;

    public class ApplicationInitializationService : ApplicationInitializationServiceBase
    {
        private readonly IServiceLocator _serviceLocator;

        public ApplicationInitializationService(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            _serviceLocator = serviceLocator;
        }

        public override Task InitializeBeforeCreatingShellAsync()
        {
            InitializeFonts();
            RegisterTypes();

            return TaskHelper.Completed;
        }

        private void InitializeFonts()
        {
            FontImage.RegisterFont("FontAwesome", new FontFamily(new Uri("pack://application:,,,/Orc.Snapshots.Example;component/Resources/Fonts/", UriKind.RelativeOrAbsolute), "./#FontAwesome"));

            FontImage.DefaultBrush = new SolidColorBrush(Color.FromArgb(255, 87, 87, 87));
            FontImage.DefaultFontFamily = "FontAwesome";
        }

        private void RegisterTypes()
        {
        }
    }
}