/*
  <auto-generated/>
  C# bindings for Simple DirectMedia Layer.
  Original copyright notice of input files:

  Simple DirectMedia Layer
  Copyright (C) 1997-2024 Sam Lantinga <slouken@libsdl.org>

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Runtime.InteropServices;

namespace SDL
{
    [Flags]
    public enum SDL_InitFlags
    {
        SDL_INIT_TIMER = 0x00000001,
        SDL_INIT_AUDIO = 0x00000010,
        SDL_INIT_VIDEO = 0x00000020,
        SDL_INIT_JOYSTICK = 0x00000200,
        SDL_INIT_HAPTIC = 0x00001000,
        SDL_INIT_GAMEPAD = 0x00002000,
        SDL_INIT_EVENTS = 0x00004000,
        SDL_INIT_SENSOR = 0x00008000,
        SDL_INIT_CAMERA = 0x00010000,
    }

    public static partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_Init(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_InitSubSystem(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_QuitSubSystem(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_InitFlags SDL_WasInit(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_Quit();
    }
}
