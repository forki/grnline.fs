﻿module Culture

open System.Runtime.InteropServices
open System.Globalization

[<DllImport("kernel32.dll")>]
extern int GetSystemDefaultLCID()

let get_codepage = 
    let lcid = GetSystemDefaultLCID()
    let ci = System.Globalization.CultureInfo(lcid)
    ci.TextInfo.OEMCodePage