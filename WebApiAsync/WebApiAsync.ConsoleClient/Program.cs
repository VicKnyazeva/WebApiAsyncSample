using Serilog;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WebApiAsync.ConsoleClient
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();

        const string writePath = @"result.txt";
        const string url = "https://localhost:5001/api/Posts/";

        static async Task<PostDTO> LoadPost(int id)
        {
            string uri = $"{url}{id}";
            HttpResponseMessage response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            var post = await response.Content.ReadFromJsonAsync<PostDTO>();
            return post;
        }

        static async Task Main()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console(
                outputTemplate: "[{Timestamp:HH:mm:ss.fff} {Level:u3}] {Message:lj}{NewLine}{Exception}"
                ).CreateLogger();

            await Task.Delay(2000);

            using (var sw = File.CreateText(writePath))
            {
                List<Task<PostDTO>> tasks = new List<Task<PostDTO>>();

                for (int i = 4; i <= 13; ++i)
                {
                    tasks.Add(LoadPost(i));
                }

                try
                {
                    await Task.WhenAll(tasks);
                }
                catch (Exception ex)
                {
                    Log.Logger.Error("{message}", ex.GetBaseException().Message);
                }

                tasks.ForEach(task =>
                {
                    if (task.Exception != null)
                    {
                        Log.Logger.Error("{message}", task.Exception.GetBaseException().Message);
                    }
                    else
                    {
                        var post = task.Result;
                        WriteToFile(sw, post);
                        Log.Logger.Information("Post #{id} recorded", post.Id);
                    }
                });
            }
        }

        private static void WriteToFile(StreamWriter sw, PostDTO post)
        {
            try
            {
                sw.WriteLine($"user id: {post.UserId}");
                sw.WriteLine($"id: {post.Id}");
                sw.WriteLine($"title: {post.Title}");
                sw.WriteLine($"post: {post.Body}");
                sw.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
