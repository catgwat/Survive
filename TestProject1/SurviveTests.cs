using SurviveLibrary;
namespace TestProject1
{
    public class SurviveTests
    {
        [Fact]
        public void Test_MaxLife()
        {
            //arrange
            Race race = Race.Rookie_Hiker;
            Weapon w = new("bonk", 1, 15, 0, false, WeaponType.Hydro_Flask);

            //act
            Player player = new("Bob", 0, 0, 100, race, w);
            int expected = 98; //because Rookie Hiker race subtracts 2 from life

            player.Life += 20;
            //assert
            Assert.Equal(expected, player.Life);
        }
        [Fact]
        public void Test_WeaponDamage()
        {
            Weapon weapon = new("Blicky", 1, 20, 5, true, WeaponType.Hydro_Flask);
            Player player2 = new("Ross", 45, 0, 0, Race.Granola_Hiker, weapon);

            var actual = player2.CalcDamage();

            Assert.InRange(actual, 1, 20);
        }
    }
}