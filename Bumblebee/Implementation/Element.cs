﻿using Bumblebee.Extensions;
using Bumblebee.Interfaces;
using OpenQA.Selenium;

namespace Bumblebee.Implementation
{
    public abstract class Element : SpecificBlock
    {
        public IBlock ParentBlock { get; private set; }

        protected Element(IBlock parent, By by) : base(parent.Session, ()=>parent.Tag.GetElement(by))
        {
            ParentBlock = parent;
        }

        protected Element(IBlock parent, IWebElement el) : base(parent.Session, () => el)
        {
            ParentBlock = parent;
        }

        public virtual string Text
        {
            get { return Tag.Text; }
        }

        public virtual bool Selected
        {
            get { return Tag.Selected; }
        }
    }
}
