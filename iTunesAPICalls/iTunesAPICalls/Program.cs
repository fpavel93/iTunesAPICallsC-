using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTunesAPICalls
{
    class Program
    {
        static void Main(string[] args)
        {
            APICallMethods api = APICallMethods.getInstance();
            Console.WriteLine("Welcome to ITunes search API");

            int num = 1;
            while (num != 0)
            {
                Console.WriteLine("Please choose what kind of search do tou want:");
                Console.WriteLine("1. Regular search");
                Console.WriteLine("2. Search with more than 1 key");
                Console.WriteLine("3. Search Albums 1 and more");
                Console.WriteLine("4. Search Artist 1 and more");
                Console.WriteLine("0. For exit.");

                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        {
                                Console.WriteLine();
                                Console.WriteLine("Enter text for search: ");
                                String text = Console.ReadLine();
                                ITunesItem[] result = api.search(text);
                                if (result != null)
                                {
                                    for (int i=0; i<result.Length; i++)
                                    {
                                        Console.WriteLine(result[i].toString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No results");
                                }

                                Console.WriteLine();
                                Console.WriteLine("Press Enter to continiue");
                                text = Console.ReadLine();

                            break;
                        }
                    case 2:
                        {
                           
                                Console.WriteLine();
                                Console.WriteLine("Enter text for search: ");
                                String text = Console.ReadLine();
                                Console.WriteLine("Enter country code for for search (optional): ");
                                String country = Console.ReadLine();
                                Console.WriteLine("Enter media type for for search (optional): ");
                                Console.WriteLine("Media type could be: movie, podcast, music, musicVideo, audiobook, shortFilm, tvShow, software, ebook or all");
                                String media = Console.ReadLine();
                                ITunesItem[] result = api.searchMultipleKey(text, country, media);
                                if (result != null)
                                {
                                    for (int i = 0; i < result.Length; i++)
                                    {
                                        Console.WriteLine(result[i].toString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No results");
                                }

                                Console.WriteLine();
                                Console.WriteLine("Press Enter to continiue");
                                text = Console.ReadLine();
                            
                            break;
                        }
                    case 3:
                        {
                                Console.WriteLine();
                                Console.WriteLine("Enter text for search Albums: ");
                                String text = Console.ReadLine();
                                ITunesItem[] result = api.getAlbums(text);
                                if (result != null)
                                {
                                    for (int i = 0; i < result.Length; i++)
                                    {
                                        Console.WriteLine(result[i].toString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No results");
                                }

                                Console.WriteLine();
                                Console.WriteLine("Press Enter to continiue");
                                text = Console.ReadLine();
                            
                            break;
                        }
                    case 4:
                        {
                                Console.WriteLine();
                                Console.WriteLine("Enter text for search Artists: ");
                                String text = Console.ReadLine();
                                ITunesItem[] result = api.getArtists(text);
                                if (result != null)
                                {
                                    for (int i = 0; i < result.Length; i++)
                                    {
                                        Console.WriteLine(result[i].toString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No results");
                                }

                                Console.WriteLine();
                                Console.WriteLine("Press Enter to continiue");
                                text = Console.ReadLine();

                            break;
                        }
                }
            }
        }
    }
}
