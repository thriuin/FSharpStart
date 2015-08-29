module TypeExamples

// Type examples

//  Numeric types

(* 
    byte uy System.Byte 0 to 255 
    sbyte y System.SByte −128 to 127 
    int16 s System.Int16 −32,768 to 32,767 
    uint16 us System.UInt16 0 to 65,535 
    int, int32 System.Int32 −231 to 231−1 
    uint32 u System.UInt32 0 to 232−1 
    int64 L System.Int64 −263 to 263−1 
    uint64 UL System.UInt64 0 to 264−1 
    float System.Double 
    float32 f System.Single A single-precision floating point based on the IEEE 32 standard. Represents values with approximately 7 significant digits. 
    decimal M System.Decimal A fixed-precision floating-point type with precisely 28 digits of precision
*)

let bigint = 42UL
let floaty = 3.1415

// Alternate base types

let octo = 0o100
let hexo = 0xA000

// Conversion

let nufloat = float "3.14151617"
let nuint = int nufloat

// BigInt

let giga = 1024I * 1024I * 1024I

// Bitwise

(* &&& ||| ^^^ <<< >>> *)

let orby_1 = 0o4040
let orby_2 = 0x0404
let bw_or = orby_1 ||| orby_2


