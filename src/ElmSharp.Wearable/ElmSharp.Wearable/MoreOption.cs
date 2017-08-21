
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElmSharp.Wearable
{
    /// <summary>
    /// The MoreOption is a widget composed of the toggle(cue button) and more option view, and MoreOption can change a visibility through the toggle.
    /// Inherits Layout
    /// </summary>
    public class MoreOption : Layout
    {
        /// <summary>
        /// Sets or gets the list of more option item
        /// </summary>
        public IList<MoreOptionItem> Items { get; private set; }

        /// <summary>
        /// Selected will be triggered when the user selects an item.
        /// </summary>
        public event EventHandler<MoreOptionItemEventArgs> Selected;
        /// <summary>
        /// Clicked will be triggered when the user selects the already selected item again or selects a selector.
        /// </summary>
        public event EventHandler<MoreOptionItemEventArgs> Clicked;
        /// <summary>
        /// Opened will be triggered when more option view is shown.
        /// </summary>
        public event EventHandler Opened;
        /// <summary>
        /// Closed will be triggered when more option view is hidden.
        /// </summary>
        public event EventHandler Closed;

        SmartEvent<PointerEventArgs> _selectedEvent;
        SmartEvent<PointerEventArgs> _clickedEvent;
        SmartEvent _openedEvent;
        SmartEvent _closedEvent;

        /// <summary>
        /// Creates and initializes a new instance of MoreOption class.
        /// </summary>
        /// <param name="parent">The parent is a given container which will be attached by MoreOption as a child. It's <see cref="EvasObject"/> type.</param>
        public MoreOption(EvasObject parent) : base(parent)
        {
            Items = new MoreOptionList(this);

            _selectedEvent = new SmartEvent<PointerEventArgs>(this, "item,selected", (d, o, info) => new PointerEventArgs { Pointer = info });
            _clickedEvent = new SmartEvent<PointerEventArgs>(this, "item,clicked", (d, o, info) => new PointerEventArgs { Pointer = info });
            _openedEvent = new SmartEvent(this, "more,option,opened");
            _closedEvent = new SmartEvent(this, "more,option,closed");

            _selectedEvent.On += (s, e) =>
            {
                MoreOptionItem selected = Items.FirstOrDefault(i => i.Handle == e.Pointer);
                Selected?.Invoke(this, new MoreOptionItemEventArgs() { Item = selected });
            };

            _clickedEvent.On += (s, e) =>
            {
                MoreOptionItem selected = Items.FirstOrDefault(i => i.Handle == e.Pointer);
                Clicked?.Invoke(this, new MoreOptionItemEventArgs() { Item = selected });
            };

            _openedEvent.On += (s, e) => Opened?.Invoke(this, EventArgs.Empty);
            _closedEvent.On += (s, e) => Closed?.Invoke(this, EventArgs.Empty);

        }

        protected override IntPtr CreateHandle(EvasObject parent)
        {
            return Interop.Eext.eext_more_option_add(parent);
        }

        /// <summary>
        /// Sets or gets the direction of more option.
        /// </summary>
        public MoreOptionDirection Direction
        {
            get
            {
                int dir = Interop.Eext.eext_more_option_direction_get(this);
                return (MoreOptionDirection)dir;
            }

            set
            {
                Interop.Eext.eext_more_option_direction_set(this, (int)value);
            }
        }

        /// <summary>
        /// Sets or gets the visibility of more option view.
        /// </summary>
        public bool IsOpened
        {
            get
            {
                return Interop.Eext.eext_more_option_opened_get(this);
            }

            set
            {
                Interop.Eext.eext_more_option_opened_set(this, value);
            }
        }
    }

    /// <summary>
    /// Enumeration for More Option Direction type.
    /// </summary>
    public enum MoreOptionDirection
    {
        Top,
        Bottom,
        Left,
        Right
    }
}
