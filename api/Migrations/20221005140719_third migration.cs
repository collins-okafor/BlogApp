using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Jessica Morar" },
                    { 2, "Marie Schimmel" },
                    { 3, "Tracey Williamson" },
                    { 4, "George Kutch" },
                    { 5, "Angelo Willms" },
                    { 6, "Doyle Stiedemann" },
                    { 7, "Gwendolyn Kling" },
                    { 8, "Evelyn Block" },
                    { 9, "Miriam VonRueden" },
                    { 10, "Kristine Adams" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[,]
                {
                    { 12, 1, "Nisi iste possimus atque impedit qui blanditiis quia consectetur a.\nDucimus mollitia nesciunt autem.\nUt sunt aliquid aut deleniti.\nAutem quod impedit placeat.\nVoluptate autem cupiditate quis reprehenderit eius.\nNulla iste consectetur ipsum beatae dolorem.\nIllum quasi dolores sint quaerat molestiae nisi quae voluptas.\nFugit explicabo qui et sed voluptas sit est.\nAspernatur quae provident libero libero autem tempora aut ipsam illum.\nEt aut sit.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(6801), "Voluptates sed dignissimos non." },
                    { 18, 9, "Et quaerat sed voluptatem.\nMaiores voluptates quae provident.\nItaque error reiciendis est est veritatis dolor.\nDelectus exercitationem ducimus ut est voluptas animi sed reprehenderit.\nCum dolorum sapiente quia autem beatae ut voluptatem blanditiis.\nConsequatur voluptas non eum dolore animi dolorem dignissimos nihil iste.\nConsequatur temporibus et dignissimos.\nDolor nemo est iusto.\nDoloribus mollitia ipsa consequatur repudiandae mollitia illum consectetur.\nTemporibus blanditiis id et qui velit voluptas et aut aut.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(8853), "Delectus consectetur voluptate sint." },
                    { 16, 9, "Natus laborum sequi et itaque id unde aut ut.\nMinus ex quo iste alias aut eos tempora omnis aut.\nNecessitatibus fugit ratione.\nAmet quo dolorem alias.\nOfficiis dolores quia eos aut necessitatibus consectetur praesentium magni.\nSit aut magnam.\nEt voluptas veritatis aliquam optio.\nConsectetur modi asperiores.\nConsequatur libero dolores aut aut.\nAccusantium quisquam aut autem sed mollitia voluptatem sunt qui.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(8169), "Sit ducimus est ipsam." },
                    { 4, 9, "Quisquam aut et sed ea in dolorem alias sed ea.\nNecessitatibus animi saepe incidunt enim eaque rerum.\nDolorem et ut et aperiam eius incidunt.\nIpsa voluptatum sed praesentium.\nNumquam dolor repellat ratione.\nSoluta eos earum est molestiae ratione omnis.\nEos quia numquam saepe occaecati consequatur ut debitis.\nRatione quis culpa.\nMaiores consequuntur velit quia cupiditate alias.\nQuis cum illum eveniet dicta optio ex placeat fuga dolor.", new DateTime(2022, 10, 5, 15, 7, 18, 526, DateTimeKind.Local).AddTicks(9604), "Ipsa ut ducimus at." },
                    { 11, 8, "Quasi itaque sint perspiciatis iste enim.\nQui aliquid necessitatibus et sed.\nDicta pariatur voluptates quis quibusdam.\nPerspiciatis laboriosam id.\nAut mollitia ut atque sunt quis non fuga qui.\nMollitia veritatis ut.\nVelit necessitatibus debitis aut voluptate fuga.\nDolore voluptas esse est doloribus eum.\nEt quos fugiat voluptatem laudantium amet fugit rerum et temporibus.\nUllam qui voluptatem blanditiis aspernatur impedit accusantium quas quam.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(6463), "Quia tempora in vel." },
                    { 10, 8, "Nesciunt animi porro aperiam vitae voluptatum fugit beatae aut.\nQuia totam aut.\nQui et voluptatibus accusamus aut.\nLaborum id id id.\nNon sint reprehenderit eius dolores enim aperiam labore.\nUt sit culpa quae.\nIste fuga nisi velit voluptatem eum at accusantium in dicta.\nVeniam ea maxime dignissimos.\nNihil asperiores reiciendis exercitationem.\nSapiente quisquam eos quo.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(6077), "Ut ad pariatur dolorum." },
                    { 9, 8, "Assumenda et reprehenderit repellendus voluptate quia nisi quia.\nEst ratione quas possimus impedit soluta facilis et eius expedita.\nSit sit maiores provident autem minima ad quae.\nVoluptas id velit.\nAutem quidem dicta.\nQuibusdam voluptatum facere hic veritatis.\nEos repudiandae aperiam sed cum sit inventore omnis voluptatem exercitationem.\nEa officia aut.\nDoloribus consequuntur non ullam beatae aperiam aperiam id quam.\nQuasi deserunt voluptatem eum maxime et.", new DateTime(2022, 10, 5, 15, 7, 18, 527, DateTimeKind.Local).AddTicks(1767), "Iure deleniti tenetur id." },
                    { 15, 6, "Perspiciatis asperiores animi sunt.\nVeniam ut aperiam et ab et.\nDignissimos architecto rem doloremque velit ut quia maxime.\nVoluptatem aut recusandae quasi aut.\nUt voluptatem quasi non nihil ipsam facilis.\nOptio eius quas voluptatem nulla exercitationem unde nihil neque autem.\nRerum laboriosam sapiente cupiditate cupiditate illum.\nQuia voluptates occaecati maiores.\nQuas ut nihil quasi est minus quia atque.\nEt adipisci est consequatur optio.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(7835), "Est temporibus commodi quasi." },
                    { 14, 6, "Fugit impedit qui.\nEt sed consectetur aliquid velit.\nItaque eius autem beatae blanditiis laudantium consequatur quos et harum.\nUt ea sunt molestiae aut voluptatibus aut neque nihil.\nAnimi ea repellat ea libero vitae dolores quasi numquam vel.\nEarum ad nemo pariatur mollitia assumenda eligendi quae ipsam.\nNeque pariatur ad sunt corporis aut.\nNon eius numquam consectetur quos asperiores suscipit vel autem porro.\nEum officiis quam eligendi qui architecto animi consequuntur ut.\nMolestias non minima sed reprehenderit velit iusto.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(7452), "Voluptatem voluptatibus quasi atque." },
                    { 1, 6, "Ex quibusdam quia quibusdam et eaque numquam.\nEsse quia deleniti suscipit.\nHic distinctio illo deleniti ipsam impedit qui distinctio nisi dolorem.\nVoluptatem consequatur unde omnis maxime architecto.\nEt distinctio quia.\nRatione dolorum nam maxime officia ut quaerat distinctio.\nVitae minus rerum rem deserunt praesentium.\nCommodi quis eos pariatur perferendis ut officiis est.\nCorrupti qui et laboriosam vitae labore tempore nulla ullam sint.\nVel similique sed officia ea nobis.", new DateTime(2022, 10, 5, 15, 7, 18, 524, DateTimeKind.Local).AddTicks(6859), "Tempora soluta asperiores sapiente." },
                    { 26, 5, "Aut numquam ut repellendus.\nNisi fugit sed beatae aut quibusdam.\nVoluptatum in nulla et.\nLaudantium dolores temporibus sed quae.\nConsequatur veniam eligendi eligendi nihil adipisci quia.\nOmnis non accusantium tempora asperiores nemo veniam dolor consequatur.\nPraesentium eum autem.\nMaxime et reiciendis blanditiis tempore delectus at ipsum.\nConsequatur inventore fuga voluptatibus quas est est est et tenetur.\nEt labore ducimus.", new DateTime(2022, 10, 5, 15, 7, 18, 600, DateTimeKind.Local).AddTicks(1549), "Nostrum voluptatem libero assumenda." },
                    { 2, 5, "Veniam voluptas omnis a.\nEnim quidem quia maxime necessitatibus eum aspernatur.\nPossimus voluptatem corporis nulla inventore ipsa quia beatae accusantium.\nAutem dolorem unde dignissimos voluptas non molestias atque quibusdam esse.\nEius aut quia veniam voluptatem.\nDistinctio laboriosam est et quod sit consequatur.\nCommodi qui occaecati incidunt beatae ut explicabo aliquam.\nDelectus temporibus aut dolorem nemo est.\nVoluptate doloremque nobis dolores.\nNemo reiciendis natus et totam excepturi id.", new DateTime(2022, 10, 5, 15, 7, 18, 526, DateTimeKind.Local).AddTicks(8398), "Commodi nostrum sed architecto." },
                    { 30, 4, "Nihil natus necessitatibus sed beatae inventore.\nQuas blanditiis illo laboriosam qui qui.\nSimilique aut eius quas suscipit.\nAtque iste repellat eveniet neque officia sit.\nQuia aut vel totam ratione ratione.\nExplicabo est eaque occaecati adipisci tempora natus sed.\nPerspiciatis at harum omnis.\nCommodi omnis laborum placeat dolore recusandae et.\nDoloribus tenetur quos officiis architecto vel sunt.\nAccusamus iusto tempore officia rem labore dolor maiores.", new DateTime(2022, 10, 5, 15, 7, 18, 600, DateTimeKind.Local).AddTicks(2888), "Repellat fugit vitae eum." },
                    { 23, 4, "Ut veniam et est voluptatem quia tenetur aliquam et.\nDoloribus tenetur magni quia.\nVel quo velit veniam sed quibusdam perspiciatis.\nConsequatur facere expedita placeat ut qui quidem quisquam animi amet.\nVoluptas ex est dolorem ex aut eos.\nConsequatur quam qui error quo iste error sit ea.\nDebitis et inventore.\nExercitationem fuga recusandae commodi praesentium maiores.\nSit qui reprehenderit voluptas animi velit ut est.\nIllo deleniti laboriosam.", new DateTime(2022, 10, 5, 15, 7, 18, 600, DateTimeKind.Local).AddTicks(562), "Velit totam neque eum." },
                    { 7, 4, "Quibusdam harum eum architecto velit.\nPorro omnis quisquam expedita eaque esse.\nNemo accusantium debitis et architecto sit labore.\nEarum qui et quaerat porro reprehenderit.\nPossimus ut est repudiandae voluptates qui exercitationem sed et nam.\nDolor itaque et repudiandae quo reiciendis sit.\nRerum quasi atque porro nostrum at alias voluptates at consequatur.\nVel optio perferendis.\nSit facere consequatur quia quas quia aut quos architecto.\nSunt voluptatem corporis laudantium doloremque aut dolorem.", new DateTime(2022, 10, 5, 15, 7, 18, 527, DateTimeKind.Local).AddTicks(877), "A consequatur sit et." },
                    { 5, 4, "Maiores voluptatem a non aut exercitationem amet quidem fuga similique.\nOptio perferendis maxime cupiditate.\nRatione est nemo praesentium quas ipsam consequatur dolorem est animi.\nPariatur assumenda quia cumque eaque.\nEius numquam aut similique rem autem beatae corrupti sit ad.\nRem distinctio minus aut et rem ab.\nAb dolorum in libero.\nMagni aut excepturi ipsa suscipit.\nDucimus et sit autem quibusdam non omnis sit tempore.\nTempora ut quia ipsa nostrum aliquid maiores et consequatur.", new DateTime(2022, 10, 5, 15, 7, 18, 527, DateTimeKind.Local).AddTicks(57), "Velit aut ex vitae." },
                    { 3, 4, "Delectus iure doloribus magnam quisquam sint amet sapiente et.\nQuos dolor placeat aliquid eligendi.\nSint impedit suscipit enim aut illo.\nA voluptas laborum iure.\nEt eum repudiandae rerum incidunt.\nNisi quaerat dolore.\nEnim ipsum nemo in.\nDolorum et qui porro nesciunt quae rerum dolores.\nVel molestiae nobis repudiandae modi.\nMolestiae aut consequuntur.", new DateTime(2022, 10, 5, 15, 7, 18, 526, DateTimeKind.Local).AddTicks(9237), "Aut illo voluptatem quod." },
                    { 20, 3, "Distinctio a nihil vel fugiat temporibus error.\nSuscipit laudantium aut sunt veritatis autem at et.\nConsectetur sint veritatis inventore.\nVoluptas corrupti quia ab est atque eius cupiditate.\nA tempora a doloribus.\nOptio omnis magni laudantium.\nIpsum rerum praesentium assumenda cum iste.\nNeque officia eaque illum.\nIn molestias voluptatibus et numquam ipsum repellendus perferendis vitae atque.\nSuscipit nulla eos aut eum facilis non vel veritatis.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(9560), "Quia aut iusto quidem." },
                    { 13, 3, "Voluptatem qui commodi tenetur pariatur quia.\nIn maiores rerum autem quia.\nQuia quasi autem quis ea eum.\nDoloremque ipsam accusantium.\nDolor est odit voluptates.\nFugiat magni rem consectetur quia quidem tenetur.\nIn illum dolores quos eum consequuntur tempore accusantium.\nTempore necessitatibus fugit rem vel nam laudantium cumque esse consequatur.\nEos ipsum et.\nReprehenderit nulla voluptatem.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(7137), "Nam quasi exercitationem dolorem." },
                    { 27, 2, "Cumque maxime distinctio numquam.\nUt et porro ut cupiditate sequi sint vel.\nSit ipsum consequatur quia dolor inventore porro in sed molestiae.\nEsse quas dolor aut animi.\nMolestiae ipsum ipsa minima.\nQui velit ad delectus distinctio.\nPorro qui quibusdam adipisci et nostrum et alias corrupti ipsum.\nFuga esse corporis quia ut.\nQuis aperiam necessitatibus voluptates quis aliquid incidunt maxime laboriosam tempore.\nOmnis a ab illum qui dolor nobis qui et.", new DateTime(2022, 10, 5, 15, 7, 18, 600, DateTimeKind.Local).AddTicks(1865), "At dolores eaque soluta." },
                    { 25, 2, "Sit beatae mollitia aspernatur architecto sunt blanditiis.\nItaque ut qui illo.\nConsequuntur eaque commodi hic tempora rem.\nVel aut aliquid non nobis maiores officiis possimus maiores.\nVeritatis ipsum maiores eius esse quo temporibus.\nUt perferendis et impedit minus illo.\nQui libero quia doloribus omnis quas.\nQui velit quibusdam architecto est libero velit sunt eius.\nUt sit quia et quasi sed impedit velit.\nPraesentium quaerat blanditiis repudiandae aut vel ullam.", new DateTime(2022, 10, 5, 15, 7, 18, 600, DateTimeKind.Local).AddTicks(1203), "Blanditiis architecto exercitationem reiciendis." },
                    { 17, 2, "Accusantium rerum voluptas beatae ullam consequuntur praesentium magni maiores.\nEt qui eos sit iusto reprehenderit sit ea.\nConsequatur laudantium ut officiis incidunt totam.\nCorrupti et qui in excepturi quia magnam omnis.\nAccusantium minus non et fuga similique officia quia quo.\nBlanditiis quis et sit porro et.\nPorro id quia consequuntur assumenda.\nLaborum est quidem expedita perspiciatis officia sequi.\nNecessitatibus nemo omnis voluptate expedita magnam natus.\nOdio debitis omnis nesciunt voluptas aut ea dolore repellendus.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(8482), "Laborum soluta aspernatur maxime." },
                    { 6, 2, "Illum perspiciatis harum iusto deserunt.\nEaque sequi ipsam dolorem est.\nAccusamus itaque aliquid aspernatur qui.\nAutem qui est beatae et quae.\nSaepe facilis tempore eos sunt quia in adipisci molestias.\nMaiores sint eveniet vitae in consectetur illum consequatur numquam rerum.\nSed molestiae sit.\nSequi placeat explicabo.\nHarum id repudiandae officia.\nOptio harum consequatur sit maxime et magnam explicabo.", new DateTime(2022, 10, 5, 15, 7, 18, 527, DateTimeKind.Local).AddTicks(447), "Exercitationem quia totam doloribus." },
                    { 29, 1, "Unde magnam nihil modi quasi provident tempore rem suscipit debitis.\nSuscipit impedit veritatis et aut est repellat quo.\nEa ab quis numquam tempore.\nDelectus unde illum.\nQuisquam sed vitae voluptatem alias suscipit unde necessitatibus.\nIure velit modi tempore autem aspernatur officia.\nUnde consequuntur aliquam dolor id.\nVoluptatem error et.\nQuos omnis aut error quia expedita distinctio nesciunt mollitia aliquam.\nVeritatis sunt quaerat aut odio qui voluptas dolor.", new DateTime(2022, 10, 5, 15, 7, 18, 600, DateTimeKind.Local).AddTicks(2549), "Iste animi debitis ad." },
                    { 28, 1, "Alias libero unde.\nReiciendis illo nesciunt laudantium doloribus non assumenda accusantium.\nIpsa similique ducimus cupiditate dolorum.\nTempora non quia odio tempora harum et et.\nDebitis minus illum qui odit quaerat aliquid.\nVelit impedit optio cumque et dolores veritatis.\nEt possimus laboriosam aspernatur inventore fuga doloremque mollitia quasi in.\nDebitis tempora voluptatem asperiores ea doloribus omnis.\nAliquam fugit et sint dicta eligendi aut.\nVel molestiae reiciendis laborum aperiam.", new DateTime(2022, 10, 5, 15, 7, 18, 600, DateTimeKind.Local).AddTicks(2210), "Omnis numquam placeat et." },
                    { 24, 1, "Consectetur ea similique ad libero quisquam natus totam suscipit.\nMaiores necessitatibus asperiores.\nDebitis vitae aliquid delectus placeat.\nUt ratione ullam et ut repellat in quis sit.\nQui a placeat ut.\nCulpa aut quod dolor tempore.\nDolores architecto quia temporibus.\nVeritatis dolores laudantium sapiente.\nAnimi sint iure officia ipsa odit quia non libero.\nAd qui dicta sit doloremque.", new DateTime(2022, 10, 5, 15, 7, 18, 600, DateTimeKind.Local).AddTicks(895), "Dolor similique libero amet." },
                    { 22, 1, "Numquam et ipsa ut et esse.\nVoluptatem optio molestiae magnam molestias tenetur.\nCorrupti voluptatum quidem ducimus illum omnis aliquam blanditiis nulla distinctio.\nEos autem a facilis nobis aut labore.\nCommodi facere ut excepturi et voluptatem.\nAliquid temporibus exercitationem sit aut error.\nEarum enim fuga voluptatum sequi voluptatibus quo.\nOmnis sit eum minus.\nEaque excepturi vel aut illum aut sit deserunt.\nSint delectus qui amet.", new DateTime(2022, 10, 5, 15, 7, 18, 600, DateTimeKind.Local).AddTicks(229), "Fugit id et iure." },
                    { 21, 1, "Non quos harum quia et corrupti enim eaque.\nQui aut in atque officia ut qui nostrum.\nBeatae consequuntur et vel qui possimus sint distinctio.\nPossimus et necessitatibus et amet voluptas dolores rerum.\nVel omnis at voluptatem accusantium.\nNon et quis quasi dignissimos autem porro animi reprehenderit.\nPorro quod quibusdam porro.\nOfficiis consequatur ut.\nOmnis ipsum omnis fugiat qui vel doloribus rerum illo.\nProvident eum possimus.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(9902), "Nobis necessitatibus autem et." },
                    { 8, 10, "Ex veritatis voluptates perspiciatis odio.\nEst pariatur aut neque amet ut neque nihil.\nDolorem quibusdam recusandae culpa voluptate eos quisquam cumque cumque.\nDolorem optio quia rerum et sunt.\nMaxime et est veritatis mollitia culpa similique voluptas ullam.\nVoluptas maiores sed error accusamus ea ut aut.\nExcepturi voluptatem et fugit quidem ea non aspernatur et accusantium.\nSapiente eveniet deserunt sit nesciunt distinctio inventore.\nTempora eius commodi illum odit voluptate tenetur porro culpa.\nA exercitationem labore dolor repudiandae inventore sed debitis iure aut.", new DateTime(2022, 10, 5, 15, 7, 18, 527, DateTimeKind.Local).AddTicks(1299), "Autem dignissimos eveniet ad." },
                    { 19, 10, "Fugiat provident soluta sequi ullam deserunt quas sit numquam.\nDolorem corrupti laudantium sit consequatur aut.\nCupiditate assumenda quisquam sed perspiciatis.\nEt blanditiis neque.\nRerum dolores error non.\nAliquid et beatae veritatis eos aperiam animi adipisci tenetur.\nAccusantium sit doloremque minima sequi assumenda alias.\nUt magnam veritatis ut nam nostrum dolores iusto cumque dolores.\nEt cupiditate et dolorem ea eos.\nAliquam earum officiis eius molestiae sunt voluptas et sint perferendis.", new DateTime(2022, 10, 5, 15, 7, 18, 599, DateTimeKind.Local).AddTicks(9215), "Sequi omnis fugiat eligendi." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AuthorId",
                table: "BlogPosts",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
