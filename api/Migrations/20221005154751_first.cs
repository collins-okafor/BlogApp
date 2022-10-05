using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace api.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                    { 1, "Preston Ortiz" },
                    { 2, "Sylvia Renner" },
                    { 3, "Wallace Gleichner" },
                    { 4, "Suzanne Jones" },
                    { 5, "Marcia Collier" },
                    { 6, "Lucille O'Conner" },
                    { 7, "Cynthia Luettgen" },
                    { 8, "Jenna Hettinger" },
                    { 9, "Angelo Corwin" },
                    { 10, "Ginger McDermott" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "TimeStamp", "Title" },
                values: new object[,]
                {
                    { 2, 1, "Rerum voluptate asperiores voluptatibus.\nNumquam non culpa quo necessitatibus non ipsa sed deserunt.\nUt esse consequatur.\nSint sit ullam delectus rerum dolorem repellendus.\nNam quod sunt.\nMagnam sed qui tempore perferendis necessitatibus qui.\nUnde praesentium qui labore laboriosam est nam soluta aut.\nMinus deserunt sint pariatur quia eaque qui.\nQuae sequi maiores sunt et quo.\nIure minima voluptas rem.", new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(7104), "Aut et quis ipsa." },
                    { 1, 10, "Repellat ipsam ab.\nRepellendus corrupti dolore omnis voluptas doloribus ipsa quo.\nSequi tempora ut.\nTenetur similique dolores est fugit excepturi odio ut.\nQuia exercitationem voluptatem voluptatem quis sequi voluptatem iusto voluptatem.\nEt veniam voluptates ut.\nVelit quia provident libero est.\nMaxime culpa molestiae fuga et.\nIste nihil aut aut laborum omnis doloribus neque tenetur incidunt.\nNihil rerum error animi.", new DateTime(2022, 10, 5, 16, 47, 50, 587, DateTimeKind.Local).AddTicks(4124), "Minima adipisci occaecati eligendi." },
                    { 27, 9, "Ut enim sed.\nDolores consequatur aut autem accusamus vel adipisci et nesciunt.\nNihil minima illum aut.\nNostrum adipisci eligendi nam dignissimos et commodi voluptas quibusdam.\nEnim est in.\nSed sed aliquid tenetur.\nQui dolor ut dolore cumque.\nOfficia voluptatem quia deserunt odio perspiciatis et.\nVelit ex quo nulla est sunt ut est.\nNemo optio animi qui.", new DateTime(2022, 10, 5, 16, 47, 50, 606, DateTimeKind.Local).AddTicks(340), "Ducimus impedit repellat facilis." },
                    { 20, 9, "Error qui consequuntur pariatur exercitationem sunt qui officiis voluptates.\nVoluptatem et id.\nConsectetur optio nihil possimus officiis pariatur incidunt iusto recusandae.\nAsperiores quidem dicta nihil.\nEligendi minima facilis eos harum ab quis.\nVelit et dolor nobis est commodi corrupti.\nPerspiciatis exercitationem molestiae voluptatem.\nAssumenda cum et omnis.\nMagni rerum recusandae at expedita corrupti accusantium ex.\nPlaceat autem sint odit.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(6913), "Adipisci et quos laborum." },
                    { 17, 9, "Dicta consequatur modi pariatur sapiente nostrum illum itaque veritatis ut.\nDicta eos cupiditate sint voluptas alias maiores magni illum sit.\nIllo ut et excepturi aut et dolore vel.\nSoluta rem id et pariatur.\nEt doloribus excepturi dignissimos.\nAmet assumenda qui.\nEst hic eum sunt qui corporis est quos sunt.\nIpsam a eius ducimus corrupti sed.\nDolore rerum quaerat laborum sed eveniet libero occaecati.\nRepellat dolorum autem numquam occaecati.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(5472), "Qui nostrum ut nemo." },
                    { 11, 9, "Ab est nihil sequi aut quia dolore quos reprehenderit ut.\nUnde in voluptas voluptatem optio molestias natus libero quaerat.\nVoluptatem quia in explicabo quod ab.\nNatus fugit magnam occaecati nemo quod optio omnis id.\nEt ut adipisci iste sit consequatur in ab ipsam cupiditate.\nVelit mollitia similique animi alias molestias accusantium omnis consequuntur.\nEnim consequuntur qui.\nMinima est enim et fugiat harum assumenda a officia eligendi.\nEt voluptas consequatur dolorem alias.\nNihil cupiditate reiciendis.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(2452), "Odit consequuntur enim voluptatem." },
                    { 26, 8, "Non dolor voluptas voluptatem dignissimos laudantium.\nAut omnis nesciunt aut dolores unde unde.\nEum et blanditiis eum.\nSequi rerum iste fugiat tempore repellendus occaecati deserunt iure.\nQui ad ut aut aut omnis.\nDolor libero quae quo officia id est nihil.\nDelectus quis voluptas earum eligendi officia.\nUt voluptatem similique tempora non facilis distinctio rerum.\nPorro ea in quo incidunt maxime nam corrupti quia quisquam.\nSuscipit ipsa similique et repellendus magni veniam illum ratione.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(9870), "Adipisci ipsa aut maiores." },
                    { 21, 8, "Dolorem qui architecto ducimus reiciendis ducimus nisi expedita.\nUt molestiae id accusantium autem consequatur.\nCorrupti officia natus aut est distinctio nostrum ratione quod voluptas.\nConsectetur expedita et.\nPossimus unde et mollitia ipsa inventore odio tenetur ea ipsam.\nQuidem consequatur quis ratione aliquid eos aspernatur nulla sit.\nQui sequi consequatur quas nostrum molestiae nihil.\nEsse voluptatem alias rerum.\nDolorem illo odit dolor delectus.\nAb harum sequi distinctio eos voluptatem veniam vero mollitia.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(7396), "Illum dolor aut consequuntur." },
                    { 9, 8, "Nam fuga hic est facilis sit blanditiis.\nEt velit et eligendi eum iste aut deleniti pariatur aut.\nEos minima minima pariatur consequatur eligendi recusandae voluptas.\nAb nemo est.\nLaudantium quas repudiandae.\nQuia dolorem quo dolor et quos pariatur esse perspiciatis.\nRepudiandae ex quia tempora rem nostrum.\nOccaecati dolore iure omnis.\nVitae impedit aliquam iure eveniet quia nihil occaecati tempora aut.\nNon corporis soluta voluptatem quas tenetur repellendus molestiae.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(1337), "Quia qui debitis vel." },
                    { 28, 7, "Laudantium iure sit inventore rerum.\nQui vero ut labore magnam ex unde rerum sint autem.\nConsequatur ex nihil eos vel vel et molestiae omnis.\nAutem delectus officia.\nSunt dicta eius dolorem.\nSit exercitationem necessitatibus at quas.\nEt provident repudiandae hic.\nA vel et quo.\nNam est laudantium dicta sunt in magni.\nNecessitatibus aliquid necessitatibus hic quasi cum.", new DateTime(2022, 10, 5, 16, 47, 50, 606, DateTimeKind.Local).AddTicks(823), "Tempore a voluptatem aliquid." },
                    { 30, 6, "Dicta quidem corrupti quod eaque voluptatem.\nExpedita blanditiis quia voluptas ea corrupti voluptas ut aut.\nAt asperiores iusto nisi.\nNostrum ipsa sed sit consequuntur mollitia commodi.\nConsequatur pariatur sequi sunt consequuntur.\nEligendi ut molestiae ducimus.\nQui harum sed.\nError rerum nostrum magni qui.\nEt labore nihil veritatis molestias nisi.\nQuia nihil saepe ut nostrum dolor.", new DateTime(2022, 10, 5, 16, 47, 50, 606, DateTimeKind.Local).AddTicks(1753), "Libero rem ut eos." },
                    { 24, 6, "Totam exercitationem hic esse earum debitis atque error ea.\nMolestias nostrum ut blanditiis eum saepe aut nisi quidem est.\nConsectetur tempora animi rerum distinctio quibusdam voluptatem.\nDolorem totam omnis enim iure quos natus quibusdam.\nNeque inventore amet enim officiis.\nId quod quibusdam animi natus expedita.\nDolore quis aperiam sed minima et.\nRem minima beatae sit ut.\nDeleniti placeat voluptatem qui delectus enim explicabo.\nSit culpa nihil ullam ipsam quibusdam repellat.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(8916), "Nostrum deserunt aut rerum." },
                    { 19, 6, "Omnis maiores error minima fuga non assumenda porro eum.\nRecusandae sit aut officia voluptas dolorem magnam et aut.\nTotam quia ullam necessitatibus expedita ea omnis et voluptatem qui.\nVoluptatem nobis necessitatibus quia debitis aut fugit.\nEst ut ad natus eaque delectus et earum aliquam quibusdam.\nNesciunt in tempora iusto eum nisi nobis cum.\nUt facere nihil blanditiis et consectetur tempore.\nNon vel rerum quo dolores.\nQuos laborum consectetur est voluptatem et placeat esse.\nEnim occaecati labore velit aperiam dolore molestias.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(6429), "Voluptate accusantium sit ipsam." },
                    { 13, 6, "Ducimus magnam nesciunt maxime error eaque ipsam.\nEos saepe nisi corrupti.\nDolorem quis esse eos commodi inventore nihil ut ut incidunt.\nVoluptatum impedit aut.\nEaque aut inventore nulla est voluptas id est ut dolores.\nNulla laborum dolor doloremque eum.\nSoluta omnis veniam totam neque non.\nNulla voluptatem repellat non voluptatem eos.\nVero molestiae nihil sed omnis.\nDolores quo ab error error dolor est inventore numquam.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(3499), "Iure dolor et ut." },
                    { 22, 5, "Nemo qui sint sunt placeat magni.\nIllum maiores neque eum facere est quia sunt.\nEx dolores voluptatibus veniam.\nExercitationem dolores qui atque aut et aut facilis cupiditate inventore.\nPorro a vero expedita.\nEligendi numquam id ipsam.\nIpsum dolores aperiam enim quidem id quas dolore sed.\nEum rerum dignissimos perferendis ut est id quod et fuga.\nLaudantium odit rerum aperiam.\nVoluptatem iusto inventore nam et dolore delectus eos.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(7954), "Saepe explicabo vel ipsum." },
                    { 15, 5, "Earum placeat laboriosam ad voluptas architecto debitis et sint quisquam.\nVoluptatum ea esse et consequuntur et alias repellendus voluptas unde.\nDicta voluptatum impedit dolores at recusandae.\nSimilique nobis iste voluptatum.\nEum sed doloremque itaque debitis enim expedita et debitis et.\nPorro qui libero blanditiis quia qui sint omnis porro.\nVoluptatum distinctio et error eum.\nEarum id hic eaque.\nRepellat quis qui quis aspernatur nemo.\nVoluptatum tempore non officia.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(4431), "Iure occaecati unde quae." },
                    { 10, 5, "Qui fugiat deleniti et rerum aliquam non doloribus.\nDicta magni et occaecati.\nQui doloribus accusantium consectetur aperiam quo fugit.\nTemporibus doloremque nobis error laudantium sapiente nisi atque consequatur est.\nRerum architecto nostrum rerum laborum veniam fuga fugit eius.\nMollitia dolores culpa.\nConsectetur cumque odio iusto vitae maiores.\nHarum eveniet ipsa qui eius vel autem similique.\nMaxime ad odio architecto debitis occaecati odio quae.\nVoluptates voluptate animi saepe pariatur adipisci.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(1971), "Praesentium ad sit voluptate." },
                    { 12, 4, "Libero repellat laborum vero.\nEius quibusdam dolorum quod ea ut consequatur.\nSaepe aut labore aut debitis ad.\nLibero voluptatem eum quia sit nulla animi esse sunt omnis.\nIure itaque animi sapiente assumenda ut minus explicabo odit enim.\nUt consequatur id ut.\nHarum officiis quia molestias aut facilis quis error est laborum.\nVoluptas facere et vel ab reiciendis.\nDebitis officiis aut non sit necessitatibus.\nRepellendus ipsum nam qui possimus.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(3001), "Sint nobis et corporis." },
                    { 4, 4, "Et reiciendis nulla corporis quia sit delectus aliquid aliquid.\nUt nam odio magnam sit aut inventore.\nVoluptatem occaecati iusto veniam rem officiis quia fugiat ut iure.\nLaborum libero alias dolorum.\nVoluptatem repellat nam et maxime.\nAmet qui impedit ut tenetur et vel dolorem fugit.\nQuod expedita ut dolorum iure.\nQuas ut voluptatibus laboriosam veniam.\nQuia quod vero ut ipsa neque tempora.\nNisi natus amet enim suscipit.", new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(8902), "Et officia error eos." },
                    { 29, 3, "Voluptatum quas sed et hic veniam cumque.\nEa qui reiciendis est facere in voluptates odio possimus beatae.\nDolor dolorem quos sapiente sequi nisi deleniti laudantium labore.\nIllum atque et quae exercitationem fugit neque dignissimos.\nEos nostrum optio sequi asperiores placeat quis neque velit.\nAssumenda dolorem in qui et velit.\nMaiores perspiciatis quae veniam totam.\nLaudantium exercitationem officia distinctio id cum blanditiis praesentium maxime.\nSint earum deleniti vitae perferendis et numquam dolor dolor minima.\nTotam vero et dicta dignissimos quidem et magni dolorum in.", new DateTime(2022, 10, 5, 16, 47, 50, 606, DateTimeKind.Local).AddTicks(1285), "Sit voluptatum sunt adipisci." },
                    { 25, 3, "Modi reprehenderit labore amet numquam dolores.\nConsequatur rerum voluptatibus at voluptate laboriosam.\nVero porro numquam quidem nostrum error consequatur et autem est.\nSapiente ut aliquid ut esse aut quod ut sed quaerat.\nRepellendus qui placeat omnis facilis.\nExercitationem animi similique necessitatibus aut nulla qui atque et.\nUllam odio est sequi mollitia et veniam.\nTempora explicabo perspiciatis totam aspernatur.\nMolestias modi est.\nNon illum rerum sint et perferendis.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(9362), "Et velit officia alias." },
                    { 18, 3, "Nesciunt incidunt quae voluptates voluptatibus aperiam magnam sed veniam.\nUt voluptatem et molestiae itaque aut.\nAdipisci quasi illo neque.\nUt nemo voluptatem sed ex vero doloremque.\nQui unde harum esse.\nSit quo aliquid harum quas facilis dolores.\nSint praesentium animi magni.\nCulpa ea dolorum et eum aut fuga deserunt repellat.\nOmnis et cum reprehenderit quas eos aperiam doloribus.\nEum ut et ipsa nulla natus.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(5942), "Vel qui ut vero." },
                    { 16, 3, "Eos nihil ipsum autem omnis quidem.\nOfficiis dolorem quis quae sunt.\nDebitis molestiae omnis reprehenderit porro vitae vitae vitae.\nQuo iure quis quae.\nNecessitatibus autem eius sunt repellendus eaque.\nOfficiis non accusamus facilis labore minus.\nEt recusandae recusandae vitae.\nA illo nam cupiditate aliquam minima.\nAut in rerum qui dolor quas quo numquam totam et.\nEt voluptatem illo magnam alias qui saepe maxime voluptatum ut.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(4874), "Est asperiores quae sit." },
                    { 5, 3, "Architecto enim eum accusamus aut praesentium.\nNecessitatibus et quos.\nSint ea rem id ut ut ipsa est.\nNumquam animi repellendus alias sit totam.\nQuis explicabo autem recusandae ab.\nRerum non enim nisi.\nNulla aut ipsa ad sunt quo facilis ipsa repellendus.\nQui voluptatem est non incidunt commodi et rem atque.\nNobis perspiciatis consectetur porro autem eos natus facilis ex.\nVoluptatem nostrum fuga aspernatur velit rerum esse.", new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(9373), "In sunt et qui." },
                    { 23, 2, "Id in doloribus aspernatur ea.\nExcepturi nulla possimus esse dicta rem tempore est est.\nIure qui ut rerum rem et consectetur accusamus.\nQui et nemo.\nUt nam reprehenderit consequatur minus sit est voluptatum aut veniam.\nDolor esse soluta rerum.\nDucimus in minima quos quam est quo.\nMolestiae vero sed quia sed inventore est voluptates quia a.\nPlaceat optio aut itaque libero debitis incidunt vel fugit.\nAssumenda inventore iure.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(8405), "Repellat aut numquam quis." },
                    { 7, 2, "Iusto quasi eos quo magni et sed.\nOdio repellendus ipsa.\nRepellat dicta aliquid impedit sed ut ipsum quasi ad qui.\nMolestiae repellat minima omnis dolor voluptatem.\nEt qui dolores.\nHarum ea maiores.\nNeque molestiae et ut consequatur odit quia.\nEaque doloremque qui quam at omnis aut.\nQuia maiores est itaque voluptas pariatur enim.\nDolor ea eos eveniet odio et qui rerum est doloremque.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(388), "Iure aut aut qui." },
                    { 14, 1, "Non dolorem nihil officiis sunt rerum alias eum voluptas.\nNihil explicabo et ducimus sint consectetur.\nEnim omnis rerum.\nQui quisquam et voluptatibus et ea harum quia quidem.\nQuia iste rem.\nAspernatur repellat dolore amet consectetur dolores blanditiis quia ipsum vero.\nEos est exercitationem.\nNemo recusandae exercitationem quidem tenetur sed odit occaecati necessitatibus est.\nConsequatur non sed eum provident.\nQui occaecati qui consectetur consequatur vitae ea.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(3935), "Commodi sed pariatur culpa." },
                    { 8, 1, "Et voluptatum et occaecati ex.\nSit ratione laboriosam voluptatibus facere est quo ab nam ipsam.\nReiciendis omnis animi.\nModi dicta sed culpa.\nOptio qui nihil inventore consequatur deserunt sed esse dolores commodi.\nAutem qui rerum modi porro natus praesentium.\nAut ut cum consequatur.\nEt ipsum aut nulla doloremque culpa iure consequuntur earum.\nVelit ea odio minima laborum neque.\nUllam repudiandae ullam.", new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(900), "Maxime voluptatem minus ducimus." },
                    { 3, 10, "Praesentium animi inventore et ullam neque odit voluptatem architecto aut.\nOfficia in beatae eligendi sunt sunt nulla libero vero blanditiis.\nPlaceat aspernatur tenetur quis qui quia illo.\nEx alias facere officiis nam odio cupiditate.\nPlaceat asperiores debitis earum temporibus eum neque et debitis.\nDolor eum nihil sed molestiae nemo occaecati eos pariatur.\nTempore non laboriosam eveniet aspernatur corrupti et reiciendis fugiat non.\nAliquam error omnis explicabo cum reiciendis.\nAut sint itaque sequi dolores inventore molestiae.\nDolorem illum beatae ducimus.", new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(8189), "Repellat vel deserunt neque." },
                    { 6, 10, "Rem iste omnis amet ea qui quibusdam facilis.\nEum sint amet corporis laborum voluptas deleniti quo.\nAlias est voluptatem sed iusto.\nMolestias sit nisi hic ullam dignissimos sed voluptatum.\nVero quisquam neque sit cum nesciunt dolorem.\nDebitis cupiditate laudantium aut repudiandae saepe ad.\nPraesentium ipsam tempore.\nDucimus quam recusandae sed vitae.\nQuasi voluptatum nulla nisi nostrum nostrum ipsa quidem.\nSaepe dolorem laudantium eaque sed quia.", new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(9873), "Accusantium hic ex eos." }
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
