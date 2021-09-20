using System.Collections.Generic;

namespace Calculations.GACA
{
    public class Algorithm
    {
        public World Optimise(Rule rule,
            int numberOfWorlds,
            double mutationRate,
            int epochs,
            int updates,
            bool middle,
            bool target)
        {
            var population = Start(rule, numberOfWorlds, updates);

            var mutation = new Mutation(mutationRate);
            var crossover = new Crossover(numberOfWorlds, rule, updates, middle, target);

            for (int epoch = 0; epoch < epochs; epoch ++)
            {
                population = crossover.Execute(population);
                foreach(var world in population)
                {
                    world.Reset(mutation.Execute(world.StartState));
                }

                var currentBestWorld = Crossover.Best(population, target);
                var fitness = Crossover.Fitness(currentBestWorld, target);
                System.Diagnostics.Debug.WriteLine($"epoch {epoch} : best fitness {fitness}");
            }
            var bestWorld = Crossover.Best(population, target);
            System.Diagnostics.Debug.WriteLine($"Final best fitness = {Crossover.Fitness(bestWorld, target)}");
            return bestWorld;
        }
        public List<World> Start(Rule rule, int numberOfWorlds, int numberOfCycles)
        {
            var generator = new RowGenerator();
            var population = new List<World>();
            for (int i = 0; i < numberOfWorlds; i++)
            {
                population.Add(new World(rule, generator.Generate(), numberOfCycles));
            }
            return population;
        }


    }
}
