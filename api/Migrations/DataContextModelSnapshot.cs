﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api.Data;

namespace api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("api.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Preston Ortiz"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sylvia Renner"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wallace Gleichner"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Suzanne Jones"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Marcia Collier"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Lucille O'Conner"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Cynthia Luettgen"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Jenna Hettinger"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Angelo Corwin"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Ginger McDermott"
                        });
                });

            modelBuilder.Entity("api.Model.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Body")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 10,
                            Body = "Repellat ipsam ab.\nRepellendus corrupti dolore omnis voluptas doloribus ipsa quo.\nSequi tempora ut.\nTenetur similique dolores est fugit excepturi odio ut.\nQuia exercitationem voluptatem voluptatem quis sequi voluptatem iusto voluptatem.\nEt veniam voluptates ut.\nVelit quia provident libero est.\nMaxime culpa molestiae fuga et.\nIste nihil aut aut laborum omnis doloribus neque tenetur incidunt.\nNihil rerum error animi.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 587, DateTimeKind.Local).AddTicks(4124),
                            Title = "Minima adipisci occaecati eligendi."
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Body = "Rerum voluptate asperiores voluptatibus.\nNumquam non culpa quo necessitatibus non ipsa sed deserunt.\nUt esse consequatur.\nSint sit ullam delectus rerum dolorem repellendus.\nNam quod sunt.\nMagnam sed qui tempore perferendis necessitatibus qui.\nUnde praesentium qui labore laboriosam est nam soluta aut.\nMinus deserunt sint pariatur quia eaque qui.\nQuae sequi maiores sunt et quo.\nIure minima voluptas rem.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(7104),
                            Title = "Aut et quis ipsa."
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 10,
                            Body = "Praesentium animi inventore et ullam neque odit voluptatem architecto aut.\nOfficia in beatae eligendi sunt sunt nulla libero vero blanditiis.\nPlaceat aspernatur tenetur quis qui quia illo.\nEx alias facere officiis nam odio cupiditate.\nPlaceat asperiores debitis earum temporibus eum neque et debitis.\nDolor eum nihil sed molestiae nemo occaecati eos pariatur.\nTempore non laboriosam eveniet aspernatur corrupti et reiciendis fugiat non.\nAliquam error omnis explicabo cum reiciendis.\nAut sint itaque sequi dolores inventore molestiae.\nDolorem illum beatae ducimus.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(8189),
                            Title = "Repellat vel deserunt neque."
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            Body = "Et reiciendis nulla corporis quia sit delectus aliquid aliquid.\nUt nam odio magnam sit aut inventore.\nVoluptatem occaecati iusto veniam rem officiis quia fugiat ut iure.\nLaborum libero alias dolorum.\nVoluptatem repellat nam et maxime.\nAmet qui impedit ut tenetur et vel dolorem fugit.\nQuod expedita ut dolorum iure.\nQuas ut voluptatibus laboriosam veniam.\nQuia quod vero ut ipsa neque tempora.\nNisi natus amet enim suscipit.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(8902),
                            Title = "Et officia error eos."
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            Body = "Architecto enim eum accusamus aut praesentium.\nNecessitatibus et quos.\nSint ea rem id ut ut ipsa est.\nNumquam animi repellendus alias sit totam.\nQuis explicabo autem recusandae ab.\nRerum non enim nisi.\nNulla aut ipsa ad sunt quo facilis ipsa repellendus.\nQui voluptatem est non incidunt commodi et rem atque.\nNobis perspiciatis consectetur porro autem eos natus facilis ex.\nVoluptatem nostrum fuga aspernatur velit rerum esse.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(9373),
                            Title = "In sunt et qui."
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 10,
                            Body = "Rem iste omnis amet ea qui quibusdam facilis.\nEum sint amet corporis laborum voluptas deleniti quo.\nAlias est voluptatem sed iusto.\nMolestias sit nisi hic ullam dignissimos sed voluptatum.\nVero quisquam neque sit cum nesciunt dolorem.\nDebitis cupiditate laudantium aut repudiandae saepe ad.\nPraesentium ipsam tempore.\nDucimus quam recusandae sed vitae.\nQuasi voluptatum nulla nisi nostrum nostrum ipsa quidem.\nSaepe dolorem laudantium eaque sed quia.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 604, DateTimeKind.Local).AddTicks(9873),
                            Title = "Accusantium hic ex eos."
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 2,
                            Body = "Iusto quasi eos quo magni et sed.\nOdio repellendus ipsa.\nRepellat dicta aliquid impedit sed ut ipsum quasi ad qui.\nMolestiae repellat minima omnis dolor voluptatem.\nEt qui dolores.\nHarum ea maiores.\nNeque molestiae et ut consequatur odit quia.\nEaque doloremque qui quam at omnis aut.\nQuia maiores est itaque voluptas pariatur enim.\nDolor ea eos eveniet odio et qui rerum est doloremque.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(388),
                            Title = "Iure aut aut qui."
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 1,
                            Body = "Et voluptatum et occaecati ex.\nSit ratione laboriosam voluptatibus facere est quo ab nam ipsam.\nReiciendis omnis animi.\nModi dicta sed culpa.\nOptio qui nihil inventore consequatur deserunt sed esse dolores commodi.\nAutem qui rerum modi porro natus praesentium.\nAut ut cum consequatur.\nEt ipsum aut nulla doloremque culpa iure consequuntur earum.\nVelit ea odio minima laborum neque.\nUllam repudiandae ullam.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(900),
                            Title = "Maxime voluptatem minus ducimus."
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 8,
                            Body = "Nam fuga hic est facilis sit blanditiis.\nEt velit et eligendi eum iste aut deleniti pariatur aut.\nEos minima minima pariatur consequatur eligendi recusandae voluptas.\nAb nemo est.\nLaudantium quas repudiandae.\nQuia dolorem quo dolor et quos pariatur esse perspiciatis.\nRepudiandae ex quia tempora rem nostrum.\nOccaecati dolore iure omnis.\nVitae impedit aliquam iure eveniet quia nihil occaecati tempora aut.\nNon corporis soluta voluptatem quas tenetur repellendus molestiae.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(1337),
                            Title = "Quia qui debitis vel."
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 5,
                            Body = "Qui fugiat deleniti et rerum aliquam non doloribus.\nDicta magni et occaecati.\nQui doloribus accusantium consectetur aperiam quo fugit.\nTemporibus doloremque nobis error laudantium sapiente nisi atque consequatur est.\nRerum architecto nostrum rerum laborum veniam fuga fugit eius.\nMollitia dolores culpa.\nConsectetur cumque odio iusto vitae maiores.\nHarum eveniet ipsa qui eius vel autem similique.\nMaxime ad odio architecto debitis occaecati odio quae.\nVoluptates voluptate animi saepe pariatur adipisci.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(1971),
                            Title = "Praesentium ad sit voluptate."
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 9,
                            Body = "Ab est nihil sequi aut quia dolore quos reprehenderit ut.\nUnde in voluptas voluptatem optio molestias natus libero quaerat.\nVoluptatem quia in explicabo quod ab.\nNatus fugit magnam occaecati nemo quod optio omnis id.\nEt ut adipisci iste sit consequatur in ab ipsam cupiditate.\nVelit mollitia similique animi alias molestias accusantium omnis consequuntur.\nEnim consequuntur qui.\nMinima est enim et fugiat harum assumenda a officia eligendi.\nEt voluptas consequatur dolorem alias.\nNihil cupiditate reiciendis.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(2452),
                            Title = "Odit consequuntur enim voluptatem."
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 4,
                            Body = "Libero repellat laborum vero.\nEius quibusdam dolorum quod ea ut consequatur.\nSaepe aut labore aut debitis ad.\nLibero voluptatem eum quia sit nulla animi esse sunt omnis.\nIure itaque animi sapiente assumenda ut minus explicabo odit enim.\nUt consequatur id ut.\nHarum officiis quia molestias aut facilis quis error est laborum.\nVoluptas facere et vel ab reiciendis.\nDebitis officiis aut non sit necessitatibus.\nRepellendus ipsum nam qui possimus.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(3001),
                            Title = "Sint nobis et corporis."
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 6,
                            Body = "Ducimus magnam nesciunt maxime error eaque ipsam.\nEos saepe nisi corrupti.\nDolorem quis esse eos commodi inventore nihil ut ut incidunt.\nVoluptatum impedit aut.\nEaque aut inventore nulla est voluptas id est ut dolores.\nNulla laborum dolor doloremque eum.\nSoluta omnis veniam totam neque non.\nNulla voluptatem repellat non voluptatem eos.\nVero molestiae nihil sed omnis.\nDolores quo ab error error dolor est inventore numquam.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(3499),
                            Title = "Iure dolor et ut."
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 1,
                            Body = "Non dolorem nihil officiis sunt rerum alias eum voluptas.\nNihil explicabo et ducimus sint consectetur.\nEnim omnis rerum.\nQui quisquam et voluptatibus et ea harum quia quidem.\nQuia iste rem.\nAspernatur repellat dolore amet consectetur dolores blanditiis quia ipsum vero.\nEos est exercitationem.\nNemo recusandae exercitationem quidem tenetur sed odit occaecati necessitatibus est.\nConsequatur non sed eum provident.\nQui occaecati qui consectetur consequatur vitae ea.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(3935),
                            Title = "Commodi sed pariatur culpa."
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 5,
                            Body = "Earum placeat laboriosam ad voluptas architecto debitis et sint quisquam.\nVoluptatum ea esse et consequuntur et alias repellendus voluptas unde.\nDicta voluptatum impedit dolores at recusandae.\nSimilique nobis iste voluptatum.\nEum sed doloremque itaque debitis enim expedita et debitis et.\nPorro qui libero blanditiis quia qui sint omnis porro.\nVoluptatum distinctio et error eum.\nEarum id hic eaque.\nRepellat quis qui quis aspernatur nemo.\nVoluptatum tempore non officia.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(4431),
                            Title = "Iure occaecati unde quae."
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = 3,
                            Body = "Eos nihil ipsum autem omnis quidem.\nOfficiis dolorem quis quae sunt.\nDebitis molestiae omnis reprehenderit porro vitae vitae vitae.\nQuo iure quis quae.\nNecessitatibus autem eius sunt repellendus eaque.\nOfficiis non accusamus facilis labore minus.\nEt recusandae recusandae vitae.\nA illo nam cupiditate aliquam minima.\nAut in rerum qui dolor quas quo numquam totam et.\nEt voluptatem illo magnam alias qui saepe maxime voluptatum ut.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(4874),
                            Title = "Est asperiores quae sit."
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = 9,
                            Body = "Dicta consequatur modi pariatur sapiente nostrum illum itaque veritatis ut.\nDicta eos cupiditate sint voluptas alias maiores magni illum sit.\nIllo ut et excepturi aut et dolore vel.\nSoluta rem id et pariatur.\nEt doloribus excepturi dignissimos.\nAmet assumenda qui.\nEst hic eum sunt qui corporis est quos sunt.\nIpsam a eius ducimus corrupti sed.\nDolore rerum quaerat laborum sed eveniet libero occaecati.\nRepellat dolorum autem numquam occaecati.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(5472),
                            Title = "Qui nostrum ut nemo."
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = 3,
                            Body = "Nesciunt incidunt quae voluptates voluptatibus aperiam magnam sed veniam.\nUt voluptatem et molestiae itaque aut.\nAdipisci quasi illo neque.\nUt nemo voluptatem sed ex vero doloremque.\nQui unde harum esse.\nSit quo aliquid harum quas facilis dolores.\nSint praesentium animi magni.\nCulpa ea dolorum et eum aut fuga deserunt repellat.\nOmnis et cum reprehenderit quas eos aperiam doloribus.\nEum ut et ipsa nulla natus.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(5942),
                            Title = "Vel qui ut vero."
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = 6,
                            Body = "Omnis maiores error minima fuga non assumenda porro eum.\nRecusandae sit aut officia voluptas dolorem magnam et aut.\nTotam quia ullam necessitatibus expedita ea omnis et voluptatem qui.\nVoluptatem nobis necessitatibus quia debitis aut fugit.\nEst ut ad natus eaque delectus et earum aliquam quibusdam.\nNesciunt in tempora iusto eum nisi nobis cum.\nUt facere nihil blanditiis et consectetur tempore.\nNon vel rerum quo dolores.\nQuos laborum consectetur est voluptatem et placeat esse.\nEnim occaecati labore velit aperiam dolore molestias.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(6429),
                            Title = "Voluptate accusantium sit ipsam."
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = 9,
                            Body = "Error qui consequuntur pariatur exercitationem sunt qui officiis voluptates.\nVoluptatem et id.\nConsectetur optio nihil possimus officiis pariatur incidunt iusto recusandae.\nAsperiores quidem dicta nihil.\nEligendi minima facilis eos harum ab quis.\nVelit et dolor nobis est commodi corrupti.\nPerspiciatis exercitationem molestiae voluptatem.\nAssumenda cum et omnis.\nMagni rerum recusandae at expedita corrupti accusantium ex.\nPlaceat autem sint odit.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(6913),
                            Title = "Adipisci et quos laborum."
                        },
                        new
                        {
                            Id = 21,
                            AuthorId = 8,
                            Body = "Dolorem qui architecto ducimus reiciendis ducimus nisi expedita.\nUt molestiae id accusantium autem consequatur.\nCorrupti officia natus aut est distinctio nostrum ratione quod voluptas.\nConsectetur expedita et.\nPossimus unde et mollitia ipsa inventore odio tenetur ea ipsam.\nQuidem consequatur quis ratione aliquid eos aspernatur nulla sit.\nQui sequi consequatur quas nostrum molestiae nihil.\nEsse voluptatem alias rerum.\nDolorem illo odit dolor delectus.\nAb harum sequi distinctio eos voluptatem veniam vero mollitia.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(7396),
                            Title = "Illum dolor aut consequuntur."
                        },
                        new
                        {
                            Id = 22,
                            AuthorId = 5,
                            Body = "Nemo qui sint sunt placeat magni.\nIllum maiores neque eum facere est quia sunt.\nEx dolores voluptatibus veniam.\nExercitationem dolores qui atque aut et aut facilis cupiditate inventore.\nPorro a vero expedita.\nEligendi numquam id ipsam.\nIpsum dolores aperiam enim quidem id quas dolore sed.\nEum rerum dignissimos perferendis ut est id quod et fuga.\nLaudantium odit rerum aperiam.\nVoluptatem iusto inventore nam et dolore delectus eos.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(7954),
                            Title = "Saepe explicabo vel ipsum."
                        },
                        new
                        {
                            Id = 23,
                            AuthorId = 2,
                            Body = "Id in doloribus aspernatur ea.\nExcepturi nulla possimus esse dicta rem tempore est est.\nIure qui ut rerum rem et consectetur accusamus.\nQui et nemo.\nUt nam reprehenderit consequatur minus sit est voluptatum aut veniam.\nDolor esse soluta rerum.\nDucimus in minima quos quam est quo.\nMolestiae vero sed quia sed inventore est voluptates quia a.\nPlaceat optio aut itaque libero debitis incidunt vel fugit.\nAssumenda inventore iure.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(8405),
                            Title = "Repellat aut numquam quis."
                        },
                        new
                        {
                            Id = 24,
                            AuthorId = 6,
                            Body = "Totam exercitationem hic esse earum debitis atque error ea.\nMolestias nostrum ut blanditiis eum saepe aut nisi quidem est.\nConsectetur tempora animi rerum distinctio quibusdam voluptatem.\nDolorem totam omnis enim iure quos natus quibusdam.\nNeque inventore amet enim officiis.\nId quod quibusdam animi natus expedita.\nDolore quis aperiam sed minima et.\nRem minima beatae sit ut.\nDeleniti placeat voluptatem qui delectus enim explicabo.\nSit culpa nihil ullam ipsam quibusdam repellat.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(8916),
                            Title = "Nostrum deserunt aut rerum."
                        },
                        new
                        {
                            Id = 25,
                            AuthorId = 3,
                            Body = "Modi reprehenderit labore amet numquam dolores.\nConsequatur rerum voluptatibus at voluptate laboriosam.\nVero porro numquam quidem nostrum error consequatur et autem est.\nSapiente ut aliquid ut esse aut quod ut sed quaerat.\nRepellendus qui placeat omnis facilis.\nExercitationem animi similique necessitatibus aut nulla qui atque et.\nUllam odio est sequi mollitia et veniam.\nTempora explicabo perspiciatis totam aspernatur.\nMolestias modi est.\nNon illum rerum sint et perferendis.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(9362),
                            Title = "Et velit officia alias."
                        },
                        new
                        {
                            Id = 26,
                            AuthorId = 8,
                            Body = "Non dolor voluptas voluptatem dignissimos laudantium.\nAut omnis nesciunt aut dolores unde unde.\nEum et blanditiis eum.\nSequi rerum iste fugiat tempore repellendus occaecati deserunt iure.\nQui ad ut aut aut omnis.\nDolor libero quae quo officia id est nihil.\nDelectus quis voluptas earum eligendi officia.\nUt voluptatem similique tempora non facilis distinctio rerum.\nPorro ea in quo incidunt maxime nam corrupti quia quisquam.\nSuscipit ipsa similique et repellendus magni veniam illum ratione.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 605, DateTimeKind.Local).AddTicks(9870),
                            Title = "Adipisci ipsa aut maiores."
                        },
                        new
                        {
                            Id = 27,
                            AuthorId = 9,
                            Body = "Ut enim sed.\nDolores consequatur aut autem accusamus vel adipisci et nesciunt.\nNihil minima illum aut.\nNostrum adipisci eligendi nam dignissimos et commodi voluptas quibusdam.\nEnim est in.\nSed sed aliquid tenetur.\nQui dolor ut dolore cumque.\nOfficia voluptatem quia deserunt odio perspiciatis et.\nVelit ex quo nulla est sunt ut est.\nNemo optio animi qui.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 606, DateTimeKind.Local).AddTicks(340),
                            Title = "Ducimus impedit repellat facilis."
                        },
                        new
                        {
                            Id = 28,
                            AuthorId = 7,
                            Body = "Laudantium iure sit inventore rerum.\nQui vero ut labore magnam ex unde rerum sint autem.\nConsequatur ex nihil eos vel vel et molestiae omnis.\nAutem delectus officia.\nSunt dicta eius dolorem.\nSit exercitationem necessitatibus at quas.\nEt provident repudiandae hic.\nA vel et quo.\nNam est laudantium dicta sunt in magni.\nNecessitatibus aliquid necessitatibus hic quasi cum.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 606, DateTimeKind.Local).AddTicks(823),
                            Title = "Tempore a voluptatem aliquid."
                        },
                        new
                        {
                            Id = 29,
                            AuthorId = 3,
                            Body = "Voluptatum quas sed et hic veniam cumque.\nEa qui reiciendis est facere in voluptates odio possimus beatae.\nDolor dolorem quos sapiente sequi nisi deleniti laudantium labore.\nIllum atque et quae exercitationem fugit neque dignissimos.\nEos nostrum optio sequi asperiores placeat quis neque velit.\nAssumenda dolorem in qui et velit.\nMaiores perspiciatis quae veniam totam.\nLaudantium exercitationem officia distinctio id cum blanditiis praesentium maxime.\nSint earum deleniti vitae perferendis et numquam dolor dolor minima.\nTotam vero et dicta dignissimos quidem et magni dolorum in.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 606, DateTimeKind.Local).AddTicks(1285),
                            Title = "Sit voluptatum sunt adipisci."
                        },
                        new
                        {
                            Id = 30,
                            AuthorId = 6,
                            Body = "Dicta quidem corrupti quod eaque voluptatem.\nExpedita blanditiis quia voluptas ea corrupti voluptas ut aut.\nAt asperiores iusto nisi.\nNostrum ipsa sed sit consequuntur mollitia commodi.\nConsequatur pariatur sequi sunt consequuntur.\nEligendi ut molestiae ducimus.\nQui harum sed.\nError rerum nostrum magni qui.\nEt labore nihil veritatis molestias nisi.\nQuia nihil saepe ut nostrum dolor.",
                            TimeStamp = new DateTime(2022, 10, 5, 16, 47, 50, 606, DateTimeKind.Local).AddTicks(1753),
                            Title = "Libero rem ut eos."
                        });
                });

            modelBuilder.Entity("api.Model.BlogPost", b =>
                {
                    b.HasOne("api.Model.Author", "Author")
                        .WithMany("BlogPosts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("api.Model.Author", b =>
                {
                    b.Navigation("BlogPosts");
                });
#pragma warning restore 612, 618
        }
    }
}
