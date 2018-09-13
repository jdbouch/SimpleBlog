﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace SimpleBlog.Migrations
{
    [Migration(1)]
    public class _001_UsersAndRoles : Migration
    {
        public override void Up()
        {
            Create.Table("users")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("username").AsString(128)
                .WithColumn("email").AsCustom("varchar(256)")
                .WithColumn("password_hash").AsString(128);
          

            Create.Table("roles")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("name").AsString(128);

            Create.Table("roles_users")
              .WithColumn("userid").AsInt32().ForeignKey("users","id").OnDelete(System.Data.Rule.Cascade)
              .WithColumn("role_id").AsInt32().ForeignKey("roles","id").OnDelete(System.Data.Rule.Cascade);
        }

        public override void Down()
        {
            Delete.Table("role_users");
            Delete.Table("users");
            Delete.Table("roles");
        }
    }
}