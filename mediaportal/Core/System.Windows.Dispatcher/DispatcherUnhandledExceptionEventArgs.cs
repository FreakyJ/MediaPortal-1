#region Copyright (C) 2005-2011 Team MediaPortal

// Copyright (C) 2005-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MediaPortal is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MediaPortal is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#endregion

namespace System.Windows.Dispatcher
{
  public sealed class DispatcherUnhandledExceptionEventArgs : DispatcherEventArgs
  {
    #region Constructors

    internal DispatcherUnhandledExceptionEventArgs(Dispatcher dispatcher, Exception exception) : base(dispatcher)
    {
      _exception = exception;
    }

    #endregion Constructors

    #region Properties

    public Exception Exception
    {
      get { return _exception; }
    }

    public bool Handled
    {
      get { return _handled; }
      set { _handled = value; }
    }

    #endregion Properties

    #region Fields

    private Exception _exception;
    private bool _handled = false;

    #endregion Fields
  }
}