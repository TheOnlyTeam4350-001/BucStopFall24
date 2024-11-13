using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

/*
 * This file contains the Game class, which holds necessary information
 * about the games. Used in GamesController.cs, which has actual instances
 * of each game.
 */

namespace BucStop.Models
{
    public class VisitCount
    {
        public int Id { get; set; }

        public int VisitorCount { get; set; }

    }
}
