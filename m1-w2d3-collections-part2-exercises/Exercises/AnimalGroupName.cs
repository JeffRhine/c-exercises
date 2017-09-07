using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * Your objective with this exercise is to practice creating a dictionary
         * and adding the animal and its herd name to the dictionary.
         * 
         * You will use that dictionary to retrieve the herd name using the 
         * animalName variable.
         * 
         * You will need to figure out how to support animal names that come through in 
         * all caps, half-caps, or all-lower-case (e.g. case insensitive).
         * "elephant", "Elephant", and "ELEPHANT" should all return "Herd". 
         * 
         * If the name of the animal is not found return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * animalGroupName("giraffe") → "Tower"
         * animalGroupName("") -> "unknown"         
         * animalGroupName("walrus") -> "unknown"
         * animalGroupName("Rhino") -> "Crash"
         * animalGroupName("rhino") -> "Crash"
         * animalGroupName("elephants") -> "unknown"
         * 
         */
        public string AnimalGroupName(string animalName)
        {
            return null;
        }
    }
}
