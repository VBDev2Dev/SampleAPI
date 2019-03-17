Public Class frmMain
	 Dim rc As New RestSharp.RestClient(My.Settings.API)
	 Private Async Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		  Dim movies = Await GetMovies()
		  If Not movies.Any Then
				Await CreateSampleMovies()
				movies = Await GetMovies()
		  End If
		  MovieBindingSource.DataSource = movies
	 End Sub

	 Async Function GetMovies() As Task(Of List(Of Movie))
		  Await Task.Delay(2000)
		  Dim rq As New RestSharp.RestRequest("Movies")
		  Dim resp = Await rc.ExecuteTaskAsync(Of List(Of Movie))(rq)
		  Return resp.Data
	 End Function


	 Async Function CreateSampleMovies() As Task
		  'http://www.imdb.com/list/ls004812581/
		  Dim samples = "The Incredible Journey	Adventure, Drama, Family	10/30/1963
All Good Things	Crime, Drama, Mystery, Romance, Thriller	11/5/2010
Idiocracy	Adventure, Comedy, Sci-Fi, Thriller	9/1/2006
Scarface	Crime, Drama	12/1/1983
Puss in Boots	Animation, Action, Adventure, Comedy, Family, Fantasy	10/23/2011
The Expendables	Action, Adventure, Thriller	8/3/2010
Captain America: The First Avenger	Action, Adventure, Sci-Fi	7/19/2011
Top Gun	Action, Drama	5/12/1986
The Outsiders	Crime, Drama	3/25/1983
Half Nelson	Drama	1/23/2006
Killer Elite	Action, Crime, Thriller	9/10/2011
Secondhand Lions	Comedy, Drama, Family	9/5/2003
Titanic	Drama, Romance	11/1/1997
Revolutionary Road	Drama, Romance	12/15/2008
The Waterboy	Comedy, Sport	11/6/1998
Public Enemies	Biography, Crime, Drama, Romance	6/18/2009
The New World	Biography, Drama, History, Romance	12/25/2005
Pathfinder	Action, Adventure, Drama, Thriller	1/11/2007
This Is England	Crime, Drama	9/12/2006
Little Manhattan	Comedy, Family, Romance	9/26/2005
The Hunger Games	Action, Adventure, Sci-Fi, Thriller	3/12/2012
Pearl Harbor	Action, Drama, History, Romance, War	5/21/2001
Transformers	Action, Adventure, Sci-Fi	6/12/2007
Transformers: Revenge of the Fallen	Action, Adventure, Sci-Fi	6/19/2009
Transformers: Dark of the Moon	Action, Adventure, Sci-Fi	6/23/2011
Holes	Adventure, Comedy, Drama, Family, Mystery	4/11/2003
Hooligans	Crime, Drama, Sport	3/12/2005
Requiem for a Dream	Drama	5/14/2000
Lord of War	Crime, Drama, Thriller	9/16/2005
Alexander	Action, Adventure, Biography, Drama, History, Romance, War	11/16/2004
U-571	Action, War	4/17/2000
Bad Boys	Crime, Drama, Thriller	3/25/1983
The Karate Kid Part II	Action, Family, Romance, Sport	6/19/1986
The Karate Kid Part III	Action, Drama, Family, Sport	4/15/1989
Valhalla Rising	Adventure, Drama, Fantasy	9/4/2009
Solomon Kane	Action, Adventure, Fantasy	9/16/2009
Collateral	Crime, Drama, Thriller	8/2/2004
Frantic	Crime, Drama, Mystery, Thriller	2/16/1988
Taken	Action, Thriller	2/27/2008
Misery	Crime, Drama, Thriller	11/29/1990
Presumed Innocent	Mystery, Thriller	7/25/1990
Black Hawk Down	Drama, History, War	12/18/2001
Robin Hood: Prince of Thieves	Action, Adventure, Drama, Romance	6/14/1991
I, Robot	Action, Crime, Drama, Mystery, Sci-Fi, Thriller	7/7/2004
A Few Good Men	Drama, Thriller	12/2/1992
Dances with Wolves	Adventure, Drama, Western	10/19/1990
The Ghost and the Darkness	Adventure, Drama, Thriller	10/11/1996
The Frisco Kid	Comedy, Drama, Western	7/6/1979
Air Force One	Action, Drama, Thriller	7/21/1997
Clear and Present Danger	Action, Crime, Drama, Thriller	8/3/1994
Patriot Games	Action, Thriller	6/5/1992
The Boy in the Striped Pyjamas	Drama, War	8/28/2008
Troy	Drama, History	5/9/2004
American Graffiti	Comedy, Drama	8/1/1973
Premonition	Drama, Fantasy, Mystery, Thriller	3/12/2007
Reservoir Dogs	Crime, Drama, Thriller	1/21/1992
More American Graffiti	Comedy, Drama, War	8/3/1979
Limitless	Mystery, Sci-Fi, Thriller	3/8/2011
Almost Famous	Adventure, Comedy, Drama, Music	9/8/2000
Death Race	Action, Sci-Fi, Thriller	8/21/2008
The A-Team	Action, Adventure, Comedy, Crime, Thriller	6/3/2010
The Social Network	Biography, Drama	9/24/2010
Training Day	Crime, Drama, Thriller	9/2/2001
Disturbia	Crime, Drama, Mystery, Thriller	4/4/2007
Rise of the Planet of the Apes	Action, Drama, Sci-Fi, Thriller	7/28/2011
A Guide to Recognizing Your Saints	Crime, Drama	1/31/2006
The Runaways	Biography, Drama, Music	1/24/2010
Apocalypse Now	Drama, War	5/19/1979
Knight and Day	Action, Adventure, Comedy	6/16/2010
127 Hours	Adventure, Biography, Drama, Thriller	9/4/2010
Reign Over Me	Drama	3/20/2007
Flipped	Comedy, Drama, Romance	7/26/2010
The Kids Are All Right	Comedy, Drama, Romance	1/25/2010
Inception	Action, Adventure, Sci-Fi, Thriller	7/8/2010
Atonement	Drama, Mystery, Romance, War	8/28/2007
The Eagle	Action, Adventure, Drama, History	2/9/2011
Fight Club	Drama	9/10/1999
The Bank Job	Crime, Thriller	2/19/2008
Chicago	Comedy, Crime, Musical	12/10/2002
Eastern Promises	Crime, Drama, Thriller	9/8/2007
Match Point	Drama, Romance, Thriller	5/12/2005
Dear Frankie	Drama, Romance	5/4/2004
One Flew Over the Cuckoo's Nest	Drama	11/19/1975
Moonrise Kingdom	Adventure, Comedy, Drama, Romance	5/16/2012
One Day	Drama, Romance	8/8/2011
Batman Begins	Action, Adventure, Thriller	5/31/2005
Pineapple Express	Action, Comedy, Crime	8/6/2008
8 Mile	Drama, Music	9/8/2002
Rescue Dawn	Action, Adventure, Biography, Drama, War	9/9/2006
The School of Rock	Comedy, Music	9/9/2003
War of the Worlds	Adventure, Sci-Fi	6/13/2005
21 Jump Street	Action, Comedy, Crime	3/12/2012
True Grit	Adventure, Drama, Western	12/14/2010
The Avengers	Action, Adventure, Sci-Fi	4/11/2012
The Believer	Drama	1/19/2001
Kill the Irishman	Biography, Crime, Drama	3/11/2011
The Adventures of Tintin	Animation, Action, Adventure, Family, Mystery	10/23/2011
K-19: The Widowmaker	Drama, History, Thriller, War	7/19/2002
Sabrina	Comedy, Drama	12/15/1995
Trainspotting	Drama	2/23/1996
Buffalo Soldiers	Comedy, Crime, Drama, Thriller, War	9/8/2001
That's What I Am	Comedy, Drama, Romance	4/29/2011
Unknown	Action, Mystery, Thriller	2/16/2011
Paths of Glory	Drama, War	11/1/1957
Unforgiven	Drama, Western	8/3/1992
Borat: Cultural Learnings of America for Make Benefit Glorious Nation of Kazakhstan	Comedy	8/4/2006
Cowboys & Aliens	Action, Sci-Fi, Thriller, Western	7/29/2011
Anonymous	Drama, Thriller	9/11/2011
The Town	Crime, Drama, Thriller	9/8/2010
Blue Valentine	Drama, Romance	1/24/2010
Crazy, Stupid, Love.	Comedy, Drama, Romance	7/19/2011
Eagle Eye	Action, Mystery, Thriller	9/16/2008
Good Night, and Good Luck.	Biography, Drama, History	9/1/2005
Butch Cassidy and the Sundance Kid	Biography, Crime, Drama, Western	9/23/1969
Virginia	Drama	9/15/2010
The Ides of March	Drama, Thriller	8/31/2011
Defiance	Action, Drama, History, Thriller, War	12/31/2008
Sideways	Comedy, Drama, Romance	9/13/2004
I'm Not There	Biography, Drama, Music, Western	9/3/2007
Murder by Numbers	Crime, Mystery, Thriller	4/19/2002
Contagion	Action, Drama, Sci-Fi, Thriller	9/3/2011
Hanna	Action, Drama, Thriller	4/7/2011
The Tree of Life	Drama, Fantasy	5/16/2011
To Kill a Mockingbird	Crime, Drama	12/25/1962
Cinderella Man	Biography, Drama, Sport	5/23/2005
3:10 to Yuma	Action, Crime, Drama, Western	8/21/2007
Blade Runner	Sci-Fi, Thriller	6/25/1982
Star Wars: Episode I - The Phantom Menace	Action, Adventure, Fantasy, Sci-Fi	5/16/1999
Star Wars: Episode II - Attack of the Clones	Action, Adventure, Fantasy, Sci-Fi	5/12/2002
Walk the Line	Biography, Drama, Music, Romance	9/4/2005
Letters from Iwo Jima	Drama, History, War	11/15/2006
I Am Legend	Drama, Horror, Sci-Fi, Thriller	12/5/2007
Enemy at the Gates	Drama, History, War	2/7/2001
Fiddler on the Roof	Drama, Family, Musical, Romance	10/21/1971
RED	Action, Comedy, Crime, Thriller	9/29/2010
The Road	Adventure, Drama	9/3/2009
Cassandra's Dream	Crime, Drama, Romance, Thriller	6/18/2007
Iron Sky	Action, Comedy, Sci-Fi	2/11/2012
Bolt	Animation, Adventure, Comedy, Drama, Family	11/17/2008
The Abyss	Adventure, Drama, Mystery, Sci-Fi, Thriller	8/9/1989
The Proposition	Crime, Drama, Western	9/12/2005
Casino	Crime, Drama	4/3/1995
Dazed and Confused	Comedy	6/4/1993
Surf's Up	Animation, Comedy, Family, Sport	6/2/2007
Avatar	Action, Adventure, Fantasy, Sci-Fi	12/10/2009
Zwartboek	Drama, Thriller, War	9/1/2006
The Deer Hunter	Drama, War	12/8/1978
The Mechanic	Action, Crime, Thriller	1/13/2011
The Proposal	Comedy, Drama, Romance	6/1/2009
Six Days Seven Nights	Action, Adventure, Comedy, Romance	6/12/1998
Hollywood Homicide	Action, Comedy, Crime, Thriller	6/10/2003
Regarding Henry	Drama, Romance	7/10/1991
Witness	Crime, Drama, Romance, Thriller	2/7/1985
A Good Year	Comedy, Drama, Romance	9/9/2006
Kingdom of Heaven	Action, Adventure, Drama, History, War	5/2/2005
The Kingdom	Action, Drama, Thriller	8/22/2007
Harsh Times	Action, Crime, Drama, Thriller	9/11/2005
9	Animation, Action, Adventure, Drama, Mystery, Sci-Fi, Thriller	8/19/2009
Marie Antoinette	Biography, Drama, History, Romance	5/24/2006
Rango	Animation, Adventure, Comedy, Family, Western	2/14/2011
Die Hard	Action, Thriller	7/12/1988
Die Hard 2	Action, Thriller	7/2/1990
Die Hard: With a Vengeance	Action, Adventure, Thriller	5/15/1995
Live Free or Die Hard	Action, Thriller	6/12/2007
Immortals	Action, Drama, Fantasy, Romance	11/10/2011
50/50	Comedy, Drama, Romance	9/12/2011
Chapter 27	Biography, Crime, Drama, History	1/25/2007
Prometheus	Adventure, Mystery, Sci-Fi	4/11/2012
Safe House	Action, Adventure, Crime, Thriller	2/7/2012
Conception	Comedy, Romance	4/30/2011
Up in the Air	Drama, Romance	9/5/2009
The Departed	Crime, Drama, Thriller	9/26/2006
The Debt	Drama, Thriller	9/4/2010
Easy A	Comedy, Drama, Romance	9/11/2010
The Shawshank Redemption	Drama	9/10/1994
Invictus	Biography, Drama, History, Sport	12/3/2009
Your Highness	Adventure, Comedy, Fantasy	4/8/2011
The Adjustment Bureau	Romance, Sci-Fi, Thriller	2/14/2011
The Perfect Storm	Action, Adventure, Drama, Thriller	6/26/2000
Pirates of the Caribbean: On Stranger Tides	Action, Adventure, Fantasy	5/7/2011
Moneyball	Biography, Drama, Sport	9/9/2011
The Fighter	Biography, Drama, Sport	12/6/2010
Tinker Tailor Soldier Spy	Drama, Mystery, Thriller	9/5/2011
Looper	Action, Crime, Drama, Sci-Fi, Thriller	9/6/2012
You Don't Mess with the Zohan	Comedy	6/6/2008
Scott Pilgrim vs. the World	Action, Comedy, Fantasy, Romance	7/27/2010
The Dark Knight Rises	Action, Thriller	7/16/2012
We Were Soldiers	Action, Drama, History, War	2/25/2002
The Expendables 2	Action, Adventure, Thriller	8/8/2012
Death at a Funeral	Comedy	4/12/2010
Zombieland	Adventure, Comedy, Horror, Sci-Fi	9/25/2009
The Hobbit: An Unexpected Journey	Adventure, Family, Fantasy	11/28/2012
Traffic	Crime, Drama, Thriller	12/6/2000
Another Earth	Drama, Romance, Sci-Fi	1/24/2011
Spun	Comedy, Crime, Drama	6/30/2002
Killing Them Softly	Crime, Thriller	5/22/2012
The Dictator	Comedy	5/16/2012
God Bless America	Adventure, Comedy, Crime, Drama, Thriller	9/9/2011
Beowulf	Animation, Action, Adventure, Fantasy	11/5/2007
Se7en	Crime, Drama, Mystery, Thriller	9/15/1995
Lincoln	Biography, Drama, History, War	10/8/2012
Trust	Crime, Drama, Thriller	9/10/2010
Iron Man	Action, Adventure, Sci-Fi	4/14/2008
Django Unchained	Drama, Western	12/11/2012
Flight	Drama, Thriller	10/14/2012
Inglourious Basterds	Adventure, Drama, War	5/20/2009
The Perks of Being a Wallflower	Drama	9/8/2012
The Blind Side	Biography, Drama, Sport	11/17/2009
People Like Us	Comedy, Drama	6/15/2012
Seven Psychopaths	Comedy, Crime	9/7/2012
The Artist	Comedy, Drama, Romance	5/15/2011
Die Welle	Drama, Thriller	1/18/2008
Watchmen	Action, Drama, Mystery, Sci-Fi	2/23/2009
Schindler's List	Biography, Drama, History	11/30/1993
Minority Report	Action, Crime, Mystery, Sci-Fi, Thriller	6/17/2002
The Karate Kid	Action, Drama, Family, Sport	6/22/1984
Children of Men	Drama, Sci-Fi, Thriller	9/3/2006
V for Vendetta	Action, Drama, Sci-Fi, Thriller	12/11/2005
Kill Bill: Vol. 1	Action, Crime, Thriller	9/29/2003
Kill Bill: Vol. 2	Action, Crime, Thriller	4/8/2004
Get the Gringo	Action, Crime, Drama, Thriller	3/15/2012
Juno	Comedy, Drama	9/1/2007
Jackie Brown	Crime, Drama, Thriller	12/8/1997
The Messenger	Drama, Romance, War	1/19/2009
Extremely Loud & Incredibly Close	Adventure, Drama, Mystery	12/25/2011
The Good German	Drama, Mystery, Thriller	11/12/2006
Gangs of New York	Crime, Drama	12/9/2002
American Pie	Comedy	7/7/1999
American Pie 2	Comedy	8/6/2001
American Wedding	Comedy	7/24/2003
American Reunion	Comedy	4/4/2012
Pitch Perfect	Comedy, Music, Romance	9/28/2012
Ratatouille	Animation, Adventure, Comedy, Drama, Family, Fantasy	6/22/2007
Persepolis	Animation, Biography, Drama, War	5/23/2007
Frankenweenie	Animation, Comedy, Family, Horror, Sci-Fi	9/20/2012
No Country for Old Men	Crime, Drama, Thriller	5/19/2007
(500) Days of Summer	Comedy, Drama, Romance	1/17/2009
We Bought a Zoo	Comedy, Drama, Family	11/26/2011
Psycho	Horror, Mystery, Thriller	6/16/1960
To Save a Life	Drama	11/5/2009
Raging Bull	Biography, Drama, Sport	11/13/1980
The Way Back	Adventure, Drama, History	9/3/2010
The Chronicles of Narnia: The Lion, the Witch and the Wardrobe	Adventure, Family, Fantasy	12/7/2005
Lars and the Real Girl	Comedy, Drama, Romance	9/16/2007
Marley & Me	Comedy, Drama, Family	12/25/2008
There Will Be Blood	Drama	9/27/2007
Hugo	Adventure, Drama, Family, Fantasy, Mystery, Romance	10/10/2011
Vision - Aus dem Leben der Hildegard von Bingen	Biography, Drama, History	9/4/2009
My Week with Marilyn	Biography, Drama	10/9/2011
Mission: Impossible - Ghost Protocol	Action, Adventure, Thriller	12/7/2011
Mission: Impossible	Action, Adventure, Thriller	5/20/1996
Alien	Horror, Sci-Fi	5/25/1979
Zero Dark Thirty	Drama, Thriller	12/10/2012
Fantastic Mr. Fox	Animation, Adventure, Comedy, Crime, Drama, Family	10/14/2009
Mission: Impossible III	Action, Adventure, Thriller	4/24/2006
Mud	Drama	5/26/2012
Road to Perdition	Crime, Drama, Thriller	7/12/2002
Gangster Squad	Action, Crime, Drama, Thriller	1/7/2013
Seeking a Friend for the End of the World	Adventure, Comedy, Drama, Romance, Sci-Fi	6/18/2012
Hansel & Gretel: Witch Hunters	Action, Fantasy, Horror	1/17/2013
The Hangover	Comedy	5/30/2009
World War Z	Action, Adventure, Horror, Sci-Fi, Thriller	6/2/2013
The Thing	Horror, Mystery, Sci-Fi	6/25/1982
Shakespeare in Love	Comedy, Drama, History, Romance	12/3/1998
Bernie	Biography, Comedy, Crime, Drama	6/16/2011
Warm Bodies	Comedy, Horror, Romance	1/16/2013
Olympus Has Fallen	Action, Thriller	3/18/2013
42	Biography, Drama, Sport	4/12/2013
The Place Beyond the Pines	Crime, Drama, Thriller	9/7/2012
The Heat	Action, Comedy, Crime	6/23/2013"

		  Dim rand As New Random
		  Dim fields = samples.Split(vbCrLf.ToCharArray, StringSplitOptions.RemoveEmptyEntries).Select(Function(ln) ln.Split(vbTab))

		  Dim movies = fields.Select(Function(m) New Movie With {
													.Price = Math.Round((rand.NextDouble * 30) + 2.0, 2),
													.Title = m(0),
													.Genre = m(1),
													.ReleaseDate = Date.Parse(m(2))}).ToList


		  Dim toadd = Enumerable.Range(0, 5).Select(Function(i)
																		Dim index = rand.Next(movies.Count)
																		Dim mov = movies(index)
																		movies.RemoveAt(index)
																		Return mov
																  End Function).ToArray


		  Dim requests = toadd.Select(Function(m) New RestSharp.RestRequest("Movie", RestSharp.Method.POST).AddJsonBody(m))

		  Dim tsks = requests.Select(Function(r) rc.ExecuteTaskAsync(r))

		  Dim responses = Await Task.WhenAll(tsks.ToArray)
		  For Each resp In responses
				Console.WriteLine(resp.StatusCode)
		  Next


	 End Function
End Class
