using System;

namespace Sharp_Odin_Protocol_By_Anas.Flash
{
    public class FlashFileItem
    {
        public string FileName { get; set; }
        public bool Enable { get; set; } = true;
        public string FilePath { get; set; }
        public long RawSize { get; set; }
        public string PackageType { get; set; }

        public string DisplaySize
        {
            get { return GetBytesReadable(RawSize); }
        }

        public static string GetBytesReadable(long i)
        {
            long absolute_i = (i < 0 ? -i : i);
            string suffix;
            double readable;
            if (absolute_i >= 0x1000000000000000)
            {
                suffix = "EB";
                readable = (i >> 50);
            }
            else if (absolute_i >= 0x4000000000000)
            {
                suffix = "PB";
                readable = (i >> 40);
            }
            else if (absolute_i >= 0x10000000000)
            {
                suffix = "TB";
                readable = (i >> 30);
            }
            else if (absolute_i >= 0x40000000)
            {
                suffix = "GB";
                readable = (i >> 20);
            }
            else if (absolute_i >= 0x100000)
            {
                suffix = "MB";
                readable = (i >> 10);
            }
            else if (absolute_i >= 0x400)
            {
                suffix = "KB";
                readable = i;
            }
            else
            {
                return i.ToString("0 B");
            }
            readable = (readable / 1024);
            return readable.ToString("0.## ") + suffix;
        }
    }
}