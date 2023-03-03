/*
* Copyright (c) 2023 XXIV
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
using System;
using System.Runtime.InteropServices;

namespace Spinners
{
    public class Spinner
    {
	private IntPtr spinner;

	public enum Spinners {
	    Dots,
	    Dots2,
	    Dots3,
	    Dots4,
	    Dots5,
	    Dots6,
	    Dots7,
	    Dots8,
	    Dots9,
	    Dots10,
	    Dots11,
	    Dots12,
	    Dots8Bit,
	    Line,
	    Line2,
	    Pipe,
	    SimpleDots,
	    SimpleDotsScrolling,
	    Star,
	    Star2,
	    Flip,
	    Hamburger,
	    GrowVertical,
	    GrowHorizontal,
	    Balloon,
	    Balloon2,
	    Noise,
	    Bounce,
	    BoxBounce,
	    BoxBounce2,
	    Triangle,
	    Arc,
	    Circle,
	    SquareCorners,
	    CircleQuarters,
	    CircleHalves,
	    Squish,
	    Toggle,
	    Toggle2,
	    Toggle3,
	    Toggle4,
	    Toggle5,
	    Toggle6,
	    Toggle7,
	    Toggle8,
	    Toggle9,
	    Toggle10,
	    Toggle11,
	    Toggle12,
	    Toggle13,
	    Arrow,
	    Arrow2,
	    Arrow3,
	    BouncingBar,
	    BouncingBall,
	    Smiley,
	    Monkey,
	    Hearts,
	    Clock,
	    Earth,
	    Material,
	    Moon,
	    Runner,
	    Pong,
	    Shark,
	    Dqpb,
	    Weather,
	    Christmas,
	    Grenade,
	    Point,
	    Layer,
	    BetaWave,
	    FingerDance,
	    FistBump,
	    SoccerHeader,
	    Mindblown,
	    Speaker,
	    OrangePulse,
	    BluePulse,
	    OrangeBluePulse,
	    TimeTravel,
	    Aesthetic,
	}
	
	private Spinner() {}
	public Spinner(Spinners spinner, string message)
	{
	    var spin = Raw.spinner_new((Raw.spinner_spinners_t)((int)spinner), message);
	    var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(spin));
	    Marshal.StructureToPtr(spin, ptr, false);
	    this.spinner = ptr;
	}

	public static Spinner WithTimer(Spinners spinner, string message)
	{
	    var spin = new Spinner();
	    var sp = Raw.spinner_new_with_timer((Raw.spinner_spinners_t)((int)spinner), message);
	    var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(sp));
	    Marshal.StructureToPtr(sp, ptr, false);
	    spin.spinner = ptr;
	    return spin;
	}

	public void Stop()
	{
	    Raw.spinner_stop(this.spinner);
	}

	public void StopWithSymbol(string symbol)
	{
	    Raw.spinner_stop_with_symbol(this.spinner, symbol);
	}

	public void StopWithNewline()
	{
	    Raw.spinner_stop_with_newline(this.spinner);
	}

	public void StopWithMessage(string msg)
	{
	    Raw.spinner_stop_with_message(this.spinner, msg);
	}

	public void StopAndPersist(string symbol, string msg)
	{
	    Raw.spinner_stop_and_persist(this.spinner, symbol, msg);
	}

	~Spinner()
	{
	    Raw.spinner_clean(this.spinner);
	    Marshal.FreeHGlobal(this.spinner);
	}
    }
}
