public async Task<bool> CheckLogin([FromForm] LoginForm formModel)
{
	var sql = $"SELECT * FROM users WHERE email={formModel.Email} AND password={formModel.Password}";
	return await dbCtx.Users.FromSqlRaw(sql).AnyAsync();
}
