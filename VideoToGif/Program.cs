using FFmpeg.NET;
using System;
using System.Threading.Tasks;

namespace VideoToGif
{
    class Program
    {
        static async Task Main(string[] args)
        
        {
            var video = @"D:\ffmpeg\bin\dogs.mp4";

            await Program.Converter(video);
            Console.WriteLine("completo!");

        }

        internal static async Task Converter(string inputFile)
        {

            var splitFile = inputFile.Split(".");
            var outputFile = splitFile[0] + splitFile[1].Replace(splitFile[1], ".gif");

            var inputVideo = new MediaFile(inputFile); // arquivo origem
            var outputGif = new MediaFile(outputFile); // arquivo destino

            var ffmpeg = new Engine(@"D:\ffmpeg\bin\ffmpeg.exe"); // aponta o conversor

            await ffmpeg.ConvertAsync(inputVideo, outputGif);

        }
    }
}
