using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

/*
 * This file contains the VisitCount class, which holds necessary information
 * about the games. Used in VisitCountController.cs, which has actual instances
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
