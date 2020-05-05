using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    public class PMdcToastOptions
    {
        public const PMdcToastPosition DefaultPosition = PMdcToastPosition.BottomRight;
        public const bool DefaultShowCloseButton = true;
        public const string DefaultCloseIcon = MdcIcons.Icon__close;
        public const bool DefaultRequireInteraction = false;
        public const int DefaultTimeout = 3000;


        /// <summary>
        /// Sets the toast's position.
        /// </summary>
        public virtual PMdcToastPosition Position { get; set; } = DefaultPosition;


        /// <summary>
        /// States if the close button has to be used for closing a toast. Defaults to true and overridden to true if <see cref="PMdcToastServiceConfiguration.RequireInteraction"/> is true.
        /// </summary>
        public virtual bool ShowCloseButton { get; set; } = DefaultShowCloseButton;


        /// <summary>
        /// The close icon. Defaults to <see cref="MdcIcons.Icon__close"/>.
        /// </summary>
        public virtual string CloseIcon { get; set; } = DefaultCloseIcon;


        /// <summary>
        /// Determines whether the toast requires interation to be closed or closes automatically on a timeout. When true overrides <see cref="PMdcToastServiceConfiguration.ShowCloseButton"/> to true and ignores <see cref="PMdcToastServiceConfiguration.Timeout"/>.
        /// </summary>
        public virtual bool RequireInteraction { get; set; } = DefaultRequireInteraction;


        /// <summary>
        /// Timeout in milliseconds until the toast automatically closes. Defaults to 3000 and ignored if if <see cref="PMdcToastServiceConfiguration.RequireInteraction"/> is true.
        /// </summary>
        public virtual int Timeout { get; set; } = DefaultTimeout;
    }
}
