using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculations.GACA
{
    public class Crossover
    {
        private readonly Random _random = new Random();
        private readonly Rule _rule;
        private readonly int _populationSize;
        private readonly int _updates;
        private readonly bool _middle;
        private readonly bool _target;

        public Crossover(int populationSize, Rule rule, int updates, bool middle, bool target)
        {
            _populationSize = populationSize;
            _rule = rule;
            _updates = updates;
            _middle = middle;
            _target = target;
        }

        public List<World> Execute(List<World> population)
        {
            var rowLength = population[0].StartState.Cells.Length;
            if (population.Count != _populationSize)
            {
                throw new ArgumentException($"Expecting population size {_populationSize} got {population.Count}");
            }
            var newPopulation = new List<World>();
            var bestWorld = Best(population, _target);
            while (newPopulation.Count < _populationSize)
            {
                var mum = Tournament(PickOne(population), PickOne(population), PickOne(population));
                var dad = Tournament(PickOne(population), PickOne(population), PickOne(population));

                var newRow = Breed(mum.StartState, dad.StartState, _middle ? rowLength / 2 : _random.Next(rowLength));

                var child = new World(_rule, newRow, _updates);
                var winningWorld = new World(_rule, Tournament(child, mum, dad).StartState, _updates);
                newPopulation.Add(winningWorld);
            }
            return newPopulation;
        }
        public static World Best(List<World> population, bool target)
        {
            return population.OrderBy(w => Fitness(w, target)).Last();
        }
        public static int Fitness(World world, bool target)
        {
            return world.State.Cells.Count(c => c == target);
        }
        private T PickOne<T>(List<T> selectFrom)
        {
            return selectFrom[_random.Next(selectFrom.Count)];
        }
        private World Tournament(World world1, World world2, World world3)
        {
            var competitors = new List<World> { world1, world2, world3 };
            return Best(competitors, _target);
        }

        private Row Breed(Row mum, Row dad, int split)
        {
            var newRow = new Row();
            Array.Copy(mum.Cells, newRow.Cells, split);
            Array.Copy(dad.Cells, split, newRow.Cells, split, dad.Cells.Length - split);
            return newRow;
        }
    }
}
