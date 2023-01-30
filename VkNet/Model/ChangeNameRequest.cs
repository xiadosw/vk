﻿using System;
using Newtonsoft.Json;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о заявке на смену имени.
/// </summary>
[Serializable]
public class ChangeNameRequest
{
	/// <summary>
	/// Идентификатор заявки, необходимый для её отмены (только если
	/// ChangeNameRequest.Status
	/// </summary>
	public int? Id { get; set; }

	/// <summary>
	/// Статус заявки
	/// </summary>
	[JsonConverter(typeof(SafetyEnumJsonConverter))]
	public ChangeNameStatus Status { get; set; }

	/// <summary>
	/// Дата, после которой возможна повторная подача заявки.
	/// </summary>
	public string RepeatDate { get; set; }

	/// <summary>
	/// Имя пользователя, указанное в заявке
	/// </summary>
	public string FirstName { get; set; }

	/// <summary>
	/// Фамилия пользователя, указанная в заявке.
	/// </summary>
	public string LastName { get; set; }
}