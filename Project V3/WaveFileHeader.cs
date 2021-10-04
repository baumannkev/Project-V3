using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Project_V3
{
    public class WaveFileHeader
    {
        // For using mmioStringToFOURCC
        [DllImport("winmm.dll")]
        public static extern int mmioStringToFOURCC([MarshalAs(UnmanagedType.LPStr)] String s, int flags);
        [DllImport("winmm.dll")]
        public static extern int mciSendString(String MciCommand, String MciReturn, int MciReturnLength, int CallBack);

        /*
            Variables:
                Class variables for usage.

            Header
            ------
                ChunkID         4 bytes     int     "RIFF"
                ChunkSize       32 bytes    uint    varies
                Format          4 bytes     int     "WAVE"
            Format Chunk
            ------------
                SubChunk1ID     4 bytes     int     "fmt "
                SubChunk1Size   4 bytes     uint    varies
                AudioFormat     16 bytes    ushort  1
                NumChannels     16 bytes    ushort  varies
                SampleRate      32 bytes    uint    varies
                ByteRate        32 bytes    uint    sampleRate * blockAlign
                BlockAlign      16 bytes    ushort  NumChannels * (ByteRate / 8)
            Data Chunk
            ----------
                SubChunk2ID     4 bytes     int     "data"
                SubChunk2Size   32 bytes    uint    varies
        */

        // Chunk Head
        // identifies file as a wav file | 12 bytes total length
        // 0 - 3 "RIFF" ASCII
        // 4 - 7 total length of package to follow (binary, little endian)
        // little endian is where: "1101" is saved as "a[1], a+1[0], a+2[1], a+3[1]" (Backwards)
        // 8 - 11 "WAVE" ASCII
        public int ChunkID;
        public int ChunkSize; // incase of extra at end
        public int Format;
        // Format Chunk
        // identifies parameters (ex: sample rate)
        // 12 - 15 "fmt_" ASCII
        // 16 - 19 length of FORMAT (binary) ( 16 for PCM
        // 20 - 21 always 0x01
        // 22 - 23 channel numbers (0x01 Mono, 0x02 Stereo)
        // 24 - 27 Sample rate (binary, in Hz)
        // 28 - 31 bytes per second
        // 32 - 33 bytes per sample (1 = 8 bit mono, 2 = 8 bit stereo or 16 bit mono, 4 = 16 bit stereo
        // 34 - 35 bits per sample
        public int SubChunk1ID;
        public int SubChunk1Size;
        public ushort AudioFormat;
        public ushort NumChannels;
        public uint SampleRate;
        public uint ByteRate;
        public ushort BlockAlign;
        public ushort BitsPerSample;
        // Data Chunk
        // contains actual data (samples)
        // 36 - 39 "data" ASCII
        // 40 - 43 length of data to follow
        // 44 - ** end data (samples)
        public int SubChunk2ID;
        public int SubChunk2Size;

        /*
            clear
            Purpose:
                Used to clear the wave_file_header object information. This is 
                called usually when we want to open a new .wav file, or start
                a new .wav file in the window.
        */
        public void clear() // clears the data currently stored in the header
        {
            ChunkID = 0;
            ChunkSize = 0;
            Format = 0;
            SubChunk1ID = 0;
            SubChunk1Size = 0;
            AudioFormat = 0;
            NumChannels = 0;
            SampleRate = 0;
            ByteRate = 0;
            BlockAlign = 0;
            BitsPerSample = 0;
            SubChunk2ID = 0;
            SubChunk2Size = 0;
        }
    }
}
