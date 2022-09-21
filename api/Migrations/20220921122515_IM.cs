using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class IM : Migration
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
                    { 1, "Robert Kemmer" },
                    { 2, "Carrie Daugherty" },
                    { 3, "Sophia Dickinson" },
                    { 4, "Tommy Barton" },
                    { 5, "Brandon Heathcote" },
                    { 6, "Ruth Kuhn" },
                    { 7, "Marcia McClure" },
                    { 8, "Rachel Rutherford" },
                    { 9, "Roger Lynch" },
                    { 10, "Randal King" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[,]
                {
                    { 11, 1, "Error tenetur id in minima molestiae beatae repellendus tempora aut.\nAutem dolore distinctio.\nItaque alias aliquid vel vel fugiat eos magnam accusantium possimus.\nConsequatur consectetur voluptatem tempore sapiente.\nQuia similique ut enim labore aut blanditiis.\nDeserunt sit provident odit ut.\nDebitis adipisci nesciunt sunt voluptas ab labore eius.\nCumque nihil culpa.\nDelectus natus rerum omnis iste sint esse dolorum.\nEligendi et cumque asperiores saepe aut modi quas.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(5416), "Voluptas ea dolorum doloremque." },
                    { 9, 10, "Repellendus esse nam non qui voluptatem odio fuga.\nQui enim corporis consequatur inventore.\nUt corporis aliquid dignissimos quod dolore enim et et.\nOfficiis asperiores modi et ut et mollitia ut dolorem voluptatem.\nLabore provident iste autem doloremque ut nostrum ut.\nAdipisci repudiandae saepe provident.\nRatione sint veritatis ducimus vel voluptatum omnis possimus.\nRerum voluptas numquam adipisci doloribus delectus quo sit.\nEaque odit asperiores assumenda.\nEt impedit nisi sit quam omnis eligendi sapiente aspernatur.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(4266), "Qui et molestias amet." },
                    { 29, 9, "Architecto ut nobis.\nEius quis nostrum aut et iste tempora et.\nAut maxime et nemo.\nUt doloribus temporibus mollitia.\nEst tempore sed fugiat eos et voluptates corporis.\nUt vel laboriosam placeat ut minima aut.\nInventore sed asperiores est quia.\nEa omnis distinctio.\nCorrupti est eius iusto tempora deleniti consectetur repudiandae perferendis sit.\nMolestiae id impedit magnam porro consequatur.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(3917), "Quibusdam possimus amet molestiae." },
                    { 21, 9, "Est et rerum quia placeat asperiores dolores distinctio rem vitae.\nNam similique aut dolor nihil veritatis quia laborum sit.\nNesciunt beatae quisquam nihil reprehenderit sit aut.\nSed ut aut sed minima tenetur maiores aut.\nIncidunt commodi error nobis molestiae deleniti et.\nCommodi excepturi autem esse accusamus deleniti.\nAmet reprehenderit qui sunt.\nDolor ea consequatur magnam.\nItaque nulla perferendis magni nostrum voluptatem adipisci enim blanditiis aut.\nEt debitis ut animi.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(103), "Non nobis voluptas consequatur." },
                    { 20, 9, "Dicta est non est.\nIllo sequi enim similique sit natus ut.\nQui veniam autem voluptatem et officiis id dolore.\nNeque nostrum omnis impedit architecto quibusdam in modi itaque.\nIure similique quibusdam.\nIllum deleniti accusamus amet aut aut et omnis.\nId quas quia et odio error totam sint.\nUt tempora natus quidem inventore consequatur voluptatibus.\nOptio nisi qui natus aut.\nNon et iste.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(9631), "Aut ut temporibus nemo." },
                    { 16, 9, "Tempora omnis aut dolor excepturi et minus.\nCommodi iusto eos non voluptatem veniam dolore aliquid.\nAssumenda repellendus a itaque.\nSint explicabo tempora id.\nHic fugit fuga pariatur.\nAut similique harum eius minus velit praesentium similique totam non.\nAccusamus eum quia dolores fuga natus provident.\nAsperiores est possimus laborum architecto aperiam sint hic voluptates earum.\nAnimi id qui quia quae qui et accusantium dolorum.\nNemo numquam quos aut unde est impedit sit rem quas.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(7822), "Ab voluptas molestias quo." },
                    { 15, 9, "Inventore beatae officia.\nQuaerat sed in laudantium quaerat quia qui commodi repudiandae dolore.\nEst commodi alias ex dolores distinctio ullam quae.\nReiciendis qui quas molestiae accusamus eos ut quis fuga.\nEnim explicabo quos porro aperiam ab laborum.\nRatione qui sit explicabo sed quod esse.\nQui quia qui laborum.\nOmnis doloremque omnis alias tempore.\nVoluptatum mollitia quia vero assumenda quod autem.\nHarum velit facilis delectus corporis occaecati dolores sequi et consequatur.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(7281), "Hic quia quia maxime." },
                    { 13, 9, "Voluptas sit dolor in repellat architecto rem aliquid.\nFacere quisquam deleniti expedita aut id illum natus.\nQuisquam aliquid nostrum adipisci magnam.\nNihil quia non illo ipsum dolorem dignissimos dicta nam.\nDeserunt est amet laborum.\nMollitia doloremque consectetur corporis.\nNon deleniti modi.\nEa ab labore nam animi et ducimus similique non asperiores.\nCum perspiciatis quam dolor aut nemo quidem vel.\nEsse eum harum hic illo quia.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(6343), "Quibusdam a voluptatem at." },
                    { 3, 9, "Voluptate saepe aut doloribus quia dolorem officiis qui quis tempore.\nSunt et nisi inventore quis reprehenderit est est voluptatibus.\nOmnis architecto amet.\nNihil in voluptatem sint voluptatem.\nEum cumque doloremque accusantium sunt voluptatem.\nSed vel voluptas iste veritatis impedit voluptas molestias recusandae.\nQuia voluptatum hic voluptas.\nFugiat eos et illum et quidem rem.\nQuisquam deleniti modi ut non reprehenderit totam voluptatem atque.\nAnimi ducimus quibusdam eius.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(1177), "Nisi reiciendis qui vel." },
                    { 28, 8, "Quia sed repudiandae et itaque.\nEnim at mollitia minus aut sapiente quasi aut porro voluptas.\nVeniam eveniet aut.\nAut iste natus et quia.\nEt officiis aut exercitationem in magni ad.\nNon laboriosam aut quia asperiores.\nExpedita temporibus ut.\nVoluptas nihil veritatis optio delectus.\nEsse et tempora delectus adipisci natus aliquid modi laborum.\nUt voluptatibus qui iusto voluptate.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(3504), "Vero optio unde doloremque." },
                    { 24, 8, "Alias harum voluptatibus qui officiis.\nQuis eius inventore sit et fugiat qui est quae.\nAnimi nemo ratione autem dolorum odio non itaque quia id.\nMagnam quae totam consequatur et repudiandae ut maiores esse sint.\nQuia architecto atque aliquid ut autem.\nDignissimos eligendi reiciendis voluptas omnis aperiam non quisquam dolor distinctio.\nQuam ipsa laudantium enim rerum eaque ipsum.\nQuia voluptatem et debitis id et rem.\nDolores architecto enim enim.\nQuo repellat cum.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(1616), "Harum ut et ut." },
                    { 7, 8, "Aliquam error et ut qui nemo esse molestias soluta.\nAccusamus et culpa fuga nobis.\nDolorem et natus atque.\nAmet tempora dolor.\nNesciunt alias doloremque ut ducimus ut.\nQui pariatur sequi sequi ipsam repellat veritatis nihil.\nCorporis aliquam magnam.\nDoloremque impedit rem molestias culpa culpa perferendis ipsam voluptatem.\nEt laboriosam quisquam itaque distinctio corporis eum id.\nLaboriosam quia voluptas qui.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(3343), "Maxime harum officiis aut." },
                    { 2, 8, "Sunt sequi maiores qui dolores ut aut molestiae cumque hic.\nAb vel facilis est eligendi doloremque necessitatibus aut corporis.\nIllum sed pariatur quaerat facere voluptatum.\nConsequatur minus iusto eos dolorum ut eum.\nIpsam ab aliquam nesciunt et explicabo qui id esse omnis.\nEt quia doloremque officia dolorum reiciendis numquam.\nAd tenetur eos aut eum omnis.\nQuam ut sint sint et laudantium.\nDolor vel reiciendis quidem hic.\nVel dicta mollitia iusto atque incidunt.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(230), "Et excepturi dicta sint." },
                    { 22, 7, "Nam possimus expedita ut necessitatibus.\nVelit rerum qui officiis omnis enim facere.\nQuidem illo minima architecto commodi sit aut velit quas ut.\nSint numquam aut similique assumenda sit qui.\nDolorum enim dicta ex repellendus ea est dolor.\nQuidem aut optio corporis quia dolore.\nId minus tenetur nemo quia quia magnam magnam possimus omnis.\nQuis odio ipsam ab ut.\nSimilique magni porro unde optio dolores.\nPorro in cum omnis ea sed ut reprehenderit.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(588), "Perferendis accusantium libero molestias." },
                    { 19, 7, "Ipsum sed omnis quam.\nIllum voluptatem quam omnis.\nOccaecati distinctio placeat itaque quis qui et ipsum omnis.\nAssumenda nihil doloremque autem dolor doloremque.\nCum sed aliquid a consequatur est libero quia.\nAmet fugit et ea sit quae.\nNihil vero quia debitis reprehenderit odit.\nAutem eligendi quisquam aut.\nPlaceat dicta iure et consequuntur sequi.\nRerum sed officiis voluptatem ab vitae.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(9212), "Optio eos ad ullam." },
                    { 10, 7, "Dignissimos perspiciatis repudiandae deleniti saepe est laudantium.\nImpedit corporis enim et eos minus vero molestiae porro.\nQuisquam velit id eaque blanditiis nisi.\nRerum maiores incidunt non voluptatum accusamus ab dolor vel minus.\nConsectetur sint debitis amet amet saepe.\nPorro ratione voluptas fugiat tempora et voluptatem repellat.\nAdipisci quia repellendus voluptate sunt sunt atque rerum.\nUt quis ut iusto modi magnam ab.\nCommodi ut sed et provident modi nulla voluptate id adipisci.\nFugit possimus maiores voluptatem voluptatum quia vero inventore.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(4796), "Porro quia repudiandae provident." },
                    { 26, 6, "Aut suscipit omnis molestiae et quis placeat error optio.\nUllam magni autem.\nQuidem ut ea sed necessitatibus et sapiente pariatur quia ab.\nModi sunt recusandae est at.\nAutem minus doloribus minima vel ut placeat pariatur nihil temporibus.\nSimilique eos sint dolorem dolorum laudantium in ad.\nEst voluptate doloribus voluptas tenetur perferendis quas similique.\nQuo illum officiis voluptas aperiam.\nQui et nobis qui qui est ex.\nDolorem labore minima laudantium.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(2476), "Explicabo saepe exercitationem id." },
                    { 8, 5, "Blanditiis temporibus non aut doloribus vel qui provident cupiditate.\nAccusamus a vel qui consectetur.\nVel mollitia veritatis.\nIn est cumque accusantium repudiandae et.\nReiciendis alias aut est velit.\nPraesentium et officiis eos commodi qui.\nNon est eos veniam commodi eum autem.\nUt vel porro exercitationem aut nesciunt blanditiis consequatur sunt et.\nAutem fugit rem.\nUnde et blanditiis dolores sint tenetur ipsam.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(3778), "Provident necessitatibus dolorem iste." },
                    { 6, 5, "Quasi placeat quae voluptatem quam vitae consequatur consequatur deleniti.\nTemporibus voluptatum magni.\nAut quaerat magni dignissimos minus expedita quis.\nRecusandae optio enim voluptate rerum.\nOfficiis sint iusto at.\nAperiam ea sit excepturi.\nSunt non ut sed temporibus iusto.\nQui aspernatur tempora est adipisci.\nSimilique rerum id voluptate porro vel ut.\nAut dignissimos consequatur recusandae error expedita itaque nostrum aspernatur adipisci.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(2843), "Id perferendis soluta quaerat." },
                    { 4, 5, "Quaerat aut dignissimos velit aut exercitationem et ipsum qui.\nIncidunt sequi qui quae ipsa beatae voluptas rem in.\nTotam qui eligendi.\nAliquid aut id laborum reprehenderit.\nQui veritatis temporibus nihil molestias maxime aperiam accusantium quia harum.\nUllam molestiae qui doloribus ducimus porro placeat.\nReprehenderit officiis saepe praesentium.\nCorporis odio veniam amet pariatur incidunt natus aliquam.\nDeleniti corporis dolorem commodi accusantium sed exercitationem ipsa vel.\nVoluptas mollitia ipsum saepe sapiente.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(1794), "Quo consequatur vero nulla." },
                    { 30, 4, "Optio non tempore animi.\nEst mollitia et minima velit in quam eligendi quis aut.\nEos natus fuga voluptatem a illum harum.\nQuis voluptatum ea impedit eaque aut libero.\nPraesentium iusto cupiditate quas iste debitis quia.\nEsse eius quia tempora accusantium.\nIste et voluptatem omnis soluta.\nMaxime voluptas eius debitis ullam nesciunt.\nMolestias dolore necessitatibus voluptas enim.\nAccusantium sapiente quaerat voluptas animi aperiam maiores.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(4332), "Perspiciatis asperiores consequatur doloremque." },
                    { 17, 4, "A natus sit vel.\nOmnis et nobis voluptas.\nVeniam non neque soluta ut sed voluptates recusandae est.\nUt animi cupiditate iure quia recusandae iusto.\nReprehenderit sit consequatur qui recusandae sint.\nExplicabo voluptas aut impedit facere officia.\nNobis soluta commodi et vero temporibus provident at tempore.\nDolorem qui eos ex aperiam quibusdam est ipsam fugit.\nNostrum nemo et iste.\nDolore amet debitis eligendi odit.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(8311), "Qui minus at labore." },
                    { 14, 4, "Aspernatur rerum et sed.\nDolor corrupti dolorem facere accusantium nulla consectetur.\nError ab laborum aut quam cumque saepe libero voluptas totam.\nQuam nostrum laborum voluptatum quia ut cum.\nMinus totam in ut assumenda veritatis ullam cupiditate.\nEst nihil reprehenderit maiores.\nDoloremque quos architecto quo dicta rem.\nConsequatur iste sit quia beatae optio exercitationem.\nPerferendis doloribus ea ut.\nPraesentium ducimus maiores ratione.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(6803), "Aspernatur saepe et voluptatem." },
                    { 12, 4, "Aperiam non ut repudiandae.\nTenetur rem ut similique distinctio consequatur.\nImpedit nihil similique aut amet qui.\nVelit et provident.\nSuscipit sequi consequuntur asperiores deserunt consequatur.\nTemporibus similique provident iure at fugiat non.\nEaque nam sed.\nVeritatis eaque fuga ea ea sint.\nEa a ut aut ut libero et ut perferendis possimus.\nSapiente aut eveniet consequatur.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(5927), "Qui temporibus architecto iusto." },
                    { 18, 3, "Accusantium impedit beatae est et ut ut sed error.\nIllo eos inventore quae.\nQui rerum in excepturi.\nIllum consequatur modi est animi et.\nError in ut consequatur.\nOdio adipisci est ut labore totam.\nFacere a distinctio asperiores quasi.\nAb qui facilis et.\nExercitationem occaecati rerum sed voluptatem eius atque totam quae.\nAutem dolor et voluptas qui.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(8793), "Recusandae et praesentium repudiandae." },
                    { 5, 3, "Quae iste id veritatis ea quasi laudantium nulla dolor necessitatibus.\nEnim sint ducimus.\nQui dicta eligendi numquam debitis ut.\nPerspiciatis optio dolores.\nPerspiciatis quia et rerum.\nIn illum dolor.\nMaxime error corporis fuga laudantium fugiat.\nQuidem praesentium eligendi quia.\nDucimus provident dignissimos illum rem assumenda iste est.\nAut et non enim non eos molestiae incidunt qui dolores.", new DateTime(2022, 9, 21, 13, 25, 15, 181, DateTimeKind.Local).AddTicks(2372), "Ut neque maiores iusto." },
                    { 27, 2, "Sed minima eum maxime voluptatem quia.\nEaque sit similique doloribus ut nulla est dolorem velit.\nIllum omnis facere unde consequuntur suscipit.\nNeque animi cum unde.\nEaque cum id praesentium laudantium.\nFacere quia et et commodi sit eligendi molestiae.\nConsectetur at qui iste quidem quisquam aut dolor suscipit.\nEt asperiores rerum neque culpa unde est.\nNam qui necessitatibus iure excepturi.\nRepellat architecto quis omnis dolorem velit.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(2983), "Provident animi aut ea." },
                    { 1, 2, "Aut sit quam laborum autem corporis cum deleniti ducimus.\nAut et reprehenderit qui porro quo temporibus officia eligendi et.\nVoluptates doloremque tempora tempora voluptatibus.\nNesciunt ab saepe est sit explicabo.\nDolorem asperiores eius.\nEt quia asperiores dolore facere.\nDicta sunt placeat.\nMinus aliquid rerum rerum dolores minima.\nAspernatur corporis consectetur iure reprehenderit officiis.\nEt omnis adipisci dolorem suscipit ad ut.", new DateTime(2022, 9, 21, 13, 25, 15, 179, DateTimeKind.Local).AddTicks(3235), "Minus sed dolorem sed." },
                    { 23, 10, "Quam esse voluptatem fugiat animi aut accusantium commodi nisi.\nQui natus veniam.\nAsperiores non esse et labore minima deserunt molestiae.\nRem nulla omnis excepturi voluptatibus ipsam et.\nPerferendis nesciunt in ratione porro.\nQuo explicabo corrupti facilis ex inventore natus consectetur.\nSint non in odio deserunt veritatis quibusdam aut et.\nAut unde doloribus ab dolores quae.\nVoluptates assumenda similique.\nNihil deserunt minima quo cumque vel.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(1109), "Aut delectus eaque vel." },
                    { 25, 10, "Voluptates minus est.\nAsperiores rem repellat ut consequuntur dignissimos.\nPossimus ab sint cupiditate.\nLabore dolores nostrum saepe autem facilis accusamus iure totam.\nQuae repellendus ea aperiam omnis rerum sequi.\nFugit amet ut ipsam.\nAlias qui incidunt rerum et sunt suscipit temporibus.\nVoluptatem sunt tempore.\nAsperiores ut veniam voluptatem et.\nA velit molestiae non.", new DateTime(2022, 9, 21, 13, 25, 15, 182, DateTimeKind.Local).AddTicks(2086), "Repudiandae atque veniam iusto." }
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
