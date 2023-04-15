using System.ComponentModel.DataAnnotations;
using CommandService.Models;

namespace CommandService.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string Howto { get; set; }
        public string CommandLine { get; set; }
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}
