using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static partial class ConsoleX
    {
        public static KeyValuePair<string, string> AuthenticationCheck()
        {
            return new KeyValuePair<string, string>(ConsoleX.WriteQuestion("Username:", MessageStatus.Default), ConsoleX.PasswordCheck());
        }
    }
}
