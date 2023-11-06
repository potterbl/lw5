<h1>ILab8DictionaryPart</h1>

Розв’яжіть задачу з використанням колекції
Dictionary<TKey, TValue>.
Заданий перелік з N ігор футбольних команд з результатами матчів у
вигляді масиву рядків. Формат кожного рядка такий:
Назва_1_команди;Голів_1_команди;Назва_2_команди;Голів_2_команди
Розробити програму, яка повертає зведену таблицю результатів усіх матчів,
якщо відомо, що за перемогу команді нараховується 3 очки, за поразку – 0 очок,
за нічию – 1 очко. Таблиця результатів повинна мати такий вигляд:
Назва_Команди: Усього_ігор Перемог Нічиїх Поразок Всього_очків
При створенні програми реалізувати наступний інтерфейс:
interface ILab8DictionaryPart
{
/// <summary>
/// Returns dictionary with stats of teams in current moment
/// </summary>
public Dictionary<string, TeamResult> Stats { get; }
/// <summary>
/// Add to the stats results of game. Method automatically chose the winner and update Stats
dictionary.
/// </summary>
public void AddGame(string firstTeamName, int firstTeamGoals, string secondTeamName,

int secondTeamGoals);

}<br/>
class TeamResult<br/>
{<br/>
public int NumberOfGames { get; set; }<br/>
public int Wins { get; set; }<br/>
public int Loses { get; set; }<br/>
public int Draws { get; set; }<br/>
public int SumOfPoints { get; set; }<br/>
}<br/>

<h2>SCREENSHOTS</h2>

![Снимок экрана от 2023-11-06 15-14-13.png](images%2F%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%20%D0%BE%D1%82%202023-11-06%2015-14-13.png)![Снимок экрана от 2023-11-06 15-14-58.png](images%2F%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%20%D0%BE%D1%82%202023-11-06%2015-14-58.png)