  class APIResponse<T> {
      public bool Succeded { get; set; }
      public string Message { get; set; }
      public T Data { get; set; }
  }