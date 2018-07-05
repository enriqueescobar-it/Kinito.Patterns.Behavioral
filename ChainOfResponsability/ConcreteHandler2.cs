﻿namespace ChainOfResponsability
{
    using System;

    /// <summary>
    /// The concrete handler 2.
    /// </summary>
    public class ConcreteHandler2 : AbstractHandler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            else if (this.Successor != null)
                this.Successor.HandleRequest(request);
        }
    }
}
