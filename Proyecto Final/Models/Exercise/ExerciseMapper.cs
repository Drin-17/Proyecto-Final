using ProyectoFinal.Models.Exercise;
using RestSharp.Extensions;

namespace Poryecto_Final.Models.Exercise
{
    public class ExerciseMapper
    {
        public static ExerciseExample ExerciseExampleResponseToExerciseExample(List<ExerciseExampleResponse> response)

        {
            ExerciseExample result = new ExerciseExample();
            result.name = response.ElementAt(0).Name;
            result.muscle = response.ElementAt(0).Muscle.ToString();
            result.difficulty = response.ElementAt(0).Difficulty.ToString();
            result.instructions=response.ElementAt(0).Instructions;
            Console.WriteLine(result);
            return result;
        }
    }
}
