using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class QueryEngine<TData>
{
    public StringComparison globalStringComparison { get; }
    public Func<TData, IEnumerable<string>> searchDataCallback { get; }
    public bool searchDataOverridesStringComparison { get; }
    public StringComparison searchDataStringComparison { get; }
    public Func<string, bool, StringComparison, string, bool> searchWordMatcher { get; }
    public bool skipIncompleteFilters { get; set; }
    public bool skipUnknownFilters { get; set; }
    public bool validateFilters { get; set; }

    public QueryEngine();
    public QueryEngine(bool validateFilters);
    public QueryEngine(UnityEditor.Search.QueryValidationOptions validationOptions);

    public void AddFilter<TFilter>(string token, Func<TData, string, TFilter, bool> filterResolver, string[] supportedOperatorType = null);
    public void AddFilter<TFilter>(string token, Func<TData, TFilter> getDataFunc, string[] supportedOperatorType = null);
    public void AddFilter<TFilter>(string token, Func<TData, TFilter> getDataFunc, StringComparison stringComparison, string[] supportedOperatorType = null);
    public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, string, TFilter, bool> filterResolver, string[] supportedOperatorType = null);
    public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, TFilter> getDataFunc, string[] supportedOperatorType = null);
    public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, string, TFilter, bool> filterResolver, Func<string, TParam> parameterTransformer, string[] supportedOperatorType = null);
    public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, TFilter> getDataFunc, Func<string, TParam> parameterTransformer, string[] supportedOperatorType = null);
    public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, TFilter> getDataFunc, StringComparison stringComparison, string[] supportedOperatorType = null);
    public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, TFilter> getDataFunc, Func<string, TParam> parameterTransformer, StringComparison stringComparison, string[] supportedOperatorType = null);
    public void AddFiltersFromAttribute<TFilterAttribute, TTransformerAttribute>();
    public void AddNestedQueryAggregator<TNestedQueryData>(string token, Func<IEnumerable<TNestedQueryData>, IEnumerable<TNestedQueryData>> aggregator);
    public void AddOperator(string op);
    public void AddOperatorHandler<TFilterVariable, TFilterConstant>(string op, Func<TFilterVariable, TFilterConstant, bool> handler);
    public void AddOperatorHandler<TFilterVariable, TFilterConstant>(string op, Func<TFilterVariable, TFilterConstant, StringComparison, bool> handler);
    public void AddTypeParser<TFilterConstant>(Func<string, UnityEditor.Search.ParseResult<TFilterConstant>> parser);
    public UnityEditor.Search.Query<TData> Parse(string text, bool useFastYieldingQueryHandler = false);
    public UnityEditor.Search.Query<TData, TPayload> Parse<TQueryHandler, TPayload>(string text, UnityEditor.Search.IQueryHandlerFactory<TData, TQueryHandler, TPayload> queryHandlerFactory);
    public void RemoveFilter(string token);
    public void SetDefaultFilter(Func<TData, string, string, string, bool> handler);
    public void SetDefaultParamFilter(Func<TData, string, string, string, string, bool> handler);
    public void SetFilterNestedQueryTransformer<TNestedQueryData, TRhs>(string filterToken, Func<TNestedQueryData, TRhs> transformer);
    public void SetGlobalStringComparisonOptions(StringComparison stringComparison);
    public void SetNestedQueryHandler<TNestedQueryData>(Func<string, string, IEnumerable<TNestedQueryData>> handler);
    public void SetSearchDataCallback(Func<TData, IEnumerable<string>> getSearchDataCallback);
    public void SetSearchDataCallback(Func<TData, IEnumerable<string>> getSearchDataCallback, StringComparison stringComparison);
    public void SetSearchDataCallback(Func<TData, IEnumerable<string>> getSearchDataCallback, Func<string, string> searchWordTransformerCallback, StringComparison stringComparison);
    public void SetSearchWordMatcher(Func<string, bool, StringComparison, string, bool> wordMatcher);

}

}
