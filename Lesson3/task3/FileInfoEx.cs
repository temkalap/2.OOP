﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB
{
    public class FileInfoEx
    {
        public static IEnumerable<string> EnumLines(FileInfo file)
        {
            using var reader = file.OpenText();
            while(!reader.EndOfStream)
            {
                var line =reader.ReadLine();
                yield return line!;
            }
        }
    }
}